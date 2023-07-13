using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.Model
{
    interface IRegistracija
    {
        bool JeIspravnoVozilo { get; }
        DateTime DatumRegistracije { get; }
        void Registriraj(bool jeIspravnoVozilo, DateTime datumRegistracije);
        bool ProvjeriTehnicki(DateTime datum);
    }
}
