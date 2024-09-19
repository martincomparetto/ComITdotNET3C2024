using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Console
{
    public class Moto : Vehiculo
    {
        public Moto()
        {
            TipoVehiculo = "Moto";
        }

        public Moto(int aceleracion) : base(aceleracion)
        {
            CantidadRuedas = 2;
        }
    }
}
