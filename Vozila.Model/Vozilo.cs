using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Vozilo : CollectionBase, IRegistracija
    {
		private string _naziv;

		public string Naziv
		{
			get { return _naziv; }
			set { _naziv = value; }
		}

		private string _boja;

		public string Boja
		{
			get { return _boja; }
			set { _boja = value; }
		}

		private int _ks;

		public int Ks
		{
			get { return _ks; }
			set 
			{	if (value <= 0) 
				{
					throw new ArgumentException("Snaga nemoze niyi manja od 0");
				}
				_ks = value; 
			}
		}

        #region IRegistracija

        private bool _jeIspravno;
        public bool JeIspravnoVozilo { get; }

        private DateTime _datumRegistracije;
        public DateTime DatumRegistracije { get; }
      
        public void Registriraj(bool jeIspravnoVozilo, DateTime datumRegistracije)
        {
            Console.WriteLine("Registracija vozila: ",Environment.NewLine);
        
            if (jeIspravnoVozilo == true)
            {
                _jeIspravno = jeIspravnoVozilo;
                _datumRegistracije = datumRegistracije;
                Console.WriteLine($"Datum registracije je od: {datumRegistracije}");
            }
            else 
            {   
                _jeIspravno = false;
                Console.WriteLine("Vozilo mora biti ispravno da bi se registriralo");
            }
        }

        public bool ProvjeriTehnicki(DateTime datum)
        {
            Console.WriteLine("Provjera registracije vozila");
            if (datum > _datumRegistracije)
            {
                Console.WriteLine("Regisdtracija je istekla");
                return false;
            }
            else
            {
                Console.WriteLine("Registracija Vrijedi");
                return true;
            }

        }

        #endregion IRegistracija

        public Vozilo(int ks)
        {
            Ks = ks;
        }

		public  decimal KsToKw()
		{	
			decimal kw = (decimal)(Ks * 0.736);
			return kw;
		}

        public void Add(Vozilo novoVozilo)
        {
            base.InnerList.Add(novoVozilo);
        }

        public void Remove(Vozilo vozilo)
        {
            base.InnerList.Remove(vozilo);
        }

		public void IspisVozila()
		{
			foreach(Vozilo v in base.InnerList)
			{
                Console.WriteLine(v.ToString()); 
			}
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
