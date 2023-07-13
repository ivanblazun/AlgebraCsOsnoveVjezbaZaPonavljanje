using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Brod : Vozilo
    {
        private decimal _istisnina;

        public decimal Istisnina
        {
            get { return _istisnina; }
            set 
            {   
                if (value <= 0) 
                {
                    throw new ArgumentException("Istisnina mora biti veca od 0");
                }
                _istisnina = value;
            }
        }


        public Brod(int ks,decimal istisnina) : base(ks)
        {
            _istisnina =istisnina;
        }

        public static Brod UcitajBrod(string vrstaVozila)
        {
            Console.WriteLine("Odabrali ste {0}!", vrstaVozila);
            Console.WriteLine("\n");
            Console.WriteLine("unesite snagu broda");
            int snaga = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("unesite istisninu broda");
            decimal istisnina = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Unesite Naziv");
            string naziv = Console.ReadLine();

            Console.WriteLine("Unesite Boju");
            string boja = Console.ReadLine();

            Brod brod = new Brod(snaga,istisnina)
            {
                Naziv = naziv,
                Boja = boja,
                Ks = snaga,
                Istisnina = istisnina 
            };
            Console.WriteLine($"Unijeli ste: {brod.ToString()}");
            Console.WriteLine("==================================");

            Console.WriteLine(Environment.NewLine);
            return brod;
        }

        public override string ToString()
        {

            return string.Format("Naziv: {0} Boja: {1} Ks: {2} Istisna: {3}",
                this.Naziv,
                this.Boja,
                this.Ks,
                this.Istisnina
                );
        }

    }
}
