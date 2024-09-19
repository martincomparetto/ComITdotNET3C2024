using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Console
{
    public class Auto : Vehiculo
    {
        public int CantidadPuertas = 2;

        private bool radioPrendida = false;

        public Auto()
        {
            TipoVehiculo = "Auto";
        }

        public Auto(int acleracion) : base(acleracion)
        {
            CantidadRuedas = 4;
        }

        public void PrenderRadio()
        {
            if (!radioPrendida)
            {
                radioPrendida = true;
                System.Console.WriteLine("Radio prendida");
            }
            else
            {
                System.Console.WriteLine("La Radio ya esta prendida");
            }
        }

        public void ApagarRadio()
        {
            if (radioPrendida)
            {
                radioPrendida = false;
                System.Console.WriteLine("Radio apagada");
            }
            else
            {
                System.Console.WriteLine("La Radio ya esta apagada");
            }
        }
    }
}
