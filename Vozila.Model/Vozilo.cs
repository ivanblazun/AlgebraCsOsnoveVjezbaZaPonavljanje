using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Vozilo : CollectionBase
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
