using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Vozila.Model;

namespace Vozila.App
{
    public class Program
    {
        static void Main(string[] args)
        {   
            List<Automobil> automobili = new List<Automobil>();
            List<Vozilo> vozila = new List<Vozilo>();
            List<Motocikl> motocikli = new List<Motocikl>();
            PetljaPrograma(automobili,vozila, motocikli);

        }
        public static void PetljaPrograma(List<Automobil> automobili, List<Vozilo> vozila, List<Motocikl> motocikli)
        {
            bool running = true;
            Console.WriteLine("Unesite vozilo; brod ili automobil");
            Console.WriteLine("\n");

            string vrstaVozila = Console.ReadLine();

            while (running)
            {
                switch (vrstaVozila)
                {
                    case "brod":
                        {
                            var noviBrod = Brod.UcitajBrod(vrstaVozila);
                            vozila.Add(noviBrod);
                            IzlistajListu(vozila);
                            OdabirOdluke(ref running, automobili, vozila, motocikli);

                        }
                        break;
                    case "auto":
                        {
                            var noviAuto = Automobil.UcitajAutomobil(vrstaVozila);
                            vozila.Add(noviAuto);
                            automobili.Add(noviAuto);
                            IzlistajListu(vozila);
                            IzlistajListu(automobili);
                            OdabirOdluke(ref running, automobili, vozila, motocikli);
                        }
                        break;
                    case "motor":
                        {
                            var noviMotor = Motocikl.UcitajMotocikl(vrstaVozila);
                            vozila.Add(noviMotor);
                            motocikli.Add(noviMotor);
                            IzlistajListu(vozila);
                            IzlistajListu(automobili);
                            OdabirOdluke(ref running, automobili, vozila,motocikli);
                        }
                        break;
                    default:
                        break;
                }

            }
        }
        public static void IzlistajListu<T>(List<T> lista)
        {
            Console.WriteLine("Lista {0} je sljedeca:",nameof(lista));
            foreach (var item in lista)
            {   
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==============================",Environment.NewLine);
        }
        public static void OdabirOdluke(ref bool running, List<Automobil> automobili, List<Vozilo> vozila, List<Motocikl> motocikli)
        {
            Console.WriteLine("Zelite li nastaviti sa unosom istog tipa vozila (da), drugog tipa (drugi) ili izaci (izadi) iz programa?");
            string odluka = Console.ReadLine();
            if (odluka == "izadi")
            {   
                running = false;
            }
            else if (odluka == "drugi")
            {
                PetljaPrograma(automobili, vozila, motocikli);
            }
        }
           
    }
}
