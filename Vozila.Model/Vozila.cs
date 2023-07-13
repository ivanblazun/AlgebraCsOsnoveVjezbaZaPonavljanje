using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Vozila : CollectionBase
    {
        public void Add(Vozila novoVozilo)
        {
            base.InnerList.Add(novoVozilo);
        }

        public void Remove(Vozila vozilo)
        {
            base.InnerList.Remove(vozilo);
        }

        public void IspisVozila()
        {
            foreach (Vozilo v in base.InnerList)
            {
                Console.WriteLine(v.Naziv.ToString());
            }
        }
    }
}
