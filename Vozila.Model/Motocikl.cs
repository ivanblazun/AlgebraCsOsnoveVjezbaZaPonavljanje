using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Motocikl : Vozilo
    {
        private int _brojKotaca;

        public int BrojKotaca
        {
            get { return _brojKotaca; }
            set 
            { 
                if (value < 2 || value > 3)
                {
                    throw new ArgumentException("Unos kotaca moze bit iili 2 ili 3");
                }
                _brojKotaca = value; 
            }
        }

        private int _maxBrzina;

        public int Maxbrzina
        {
            get { return _maxBrzina; }
            set 
            {   
                if(value < 0 && value > 300)
                {
                    throw new ArgumentException("Unos moa biti izmedu 0 i 300");
                }
                _maxBrzina = value; 
            }
        }


        public Motocikl(int ks,int maxbrzina,int brojKotaca) : base(ks)
        {
            _maxBrzina=maxbrzina;
            _brojKotaca=brojKotaca;
        }

        public static Motocikl UcitajMotocikl(string vrstaVozila)
        {
            Console.WriteLine("Odabrali ste {0}!", vrstaVozila);
            Console.WriteLine("\n");
           
            Console.WriteLine("unesite snagu motora");
            int snaga = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("unesite max brzinu");
            int maxBrzina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite broj kotaca");
            int brojKotaca = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite Naziv");
            string naziv = Console.ReadLine();

            Console.WriteLine("Unesite Boju");
            string boja = Console.ReadLine();

            Motocikl motocikl = new Motocikl(snaga, maxBrzina,brojKotaca)
            {
                Naziv = naziv,
                Boja = boja,
                Ks = snaga,
                Maxbrzina = maxBrzina,
                BrojKotaca = brojKotaca

            };
            Console.WriteLine($"Unijeli ste: {motocikl.ToString()}");
            Console.WriteLine("==================================");

            Console.WriteLine(Environment.NewLine);
            return motocikl;
        }

        public override string ToString()
        {

            return string.Format("Naziv: {0} Boja: {1} Ks: {2} Max brzina: {3} Broj kotaca {4}",
                this.Naziv,
                this.Boja,
                this.Ks,
                this.Maxbrzina,
                this.BrojKotaca
                );
        }
    }
}
