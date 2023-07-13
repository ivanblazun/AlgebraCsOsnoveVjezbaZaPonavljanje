using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Automobil : Vozilo
    {
        private decimal _ccm;

        public decimal CCm
        {
            get { return _ccm; }
            set
            {   if(value <= 0)
                {
                    throw new ArgumentException("Mora biti vise od 0");
                }
                _ccm = value; 
            }
        }

       public Automobil(int ks) : base(ks)
        {
            
        }

        public Automobil(int ks, decimal ccm) : base(ks)
        {
            CCm = ccm;
        }

        public static Automobil UcitajAutomobil(string vrstaVozila) 
        {
            Console.WriteLine("Odabrali ste {0}!", vrstaVozila);
            Console.WriteLine("\n");
            
            Console.WriteLine("unesite snagu auta");
            int snaga = Convert.ToInt32(Console.ReadLine());
              
            Console.WriteLine("Unesite Naziv");
            string naziv = Console.ReadLine();

            Console.WriteLine("Unesite Boju");
            string boja = Console.ReadLine();

            Automobil automobil= new Automobil(snaga)
            {
                Naziv = naziv,
                Boja = boja,
                Ks = snaga,
            };
            Console.WriteLine($"Unijeli ste: {automobil.ToString()}");
            Console.WriteLine("==================================");
        
            Console.WriteLine(Environment.NewLine);
            return automobil;
        }

        public override string ToString()
        {   
        
            return string.Format("Naziv: {0} Boja: {1} Ks: {2}",
                this.Naziv,
                this.Boja,
                this.Ks);
        }
    }
}
