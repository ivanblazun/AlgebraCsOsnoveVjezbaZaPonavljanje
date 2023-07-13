using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    public class Automobili : CollectionBase
    {
        public void Add(Automobil noviAuto) 
        {
            base.InnerList.Add(noviAuto);
        }

        public void Remove (Automobil automobil) 
        {
            base.InnerList.Remove(automobil);
        }

        public void IspisAutomobila()
        {
            foreach (Vozilo v in base.InnerList)
            {
                Console.WriteLine(v.Naziv.ToString());
            }
        }
    }
}
