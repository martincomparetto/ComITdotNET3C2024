using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Console
{
    public class Vehiculo
    {
        public int Año = 0;
        public string Color = "";
        public int VelocidadMaxima = 0;
        public int CantidadRuedas = 0;

        private bool Encendido = false;
        private int VelocidadActual = 0;
        private int Aceleracion = 20;

        protected string TipoVehiculo = "";

        public Vehiculo()
        {

        }

        public Vehiculo(int aceleracion)
        {
            Aceleracion = aceleracion;
        }

        public void Encender()
        {
            if (!Encendido)
            {
                Encendido = true;
                System.Console.WriteLine($"{TipoVehiculo} encendido");
            }
            else
            { 
                System.Console.WriteLine($"{TipoVehiculo} ya esta en marcha");
            }
        }
        public void Apagar()
        {
            if (Encendido)
            {
                System.Console.WriteLine($"{TipoVehiculo} apagado");
            }
            else
            {
                System.Console.WriteLine($"{TipoVehiculo} no esta encendido");
            }
        }

        public void Acelerar()
        {
            Acelerar(Aceleracion);
        }

        public void Acelerar(int aceleracion)
        {
            if (Encendido)
            {
                VelocidadActual += aceleracion;
                if (VelocidadActual > VelocidadMaxima)
                {
                    System.Console.WriteLine($"La velocidad maxima es {VelocidadMaxima}. No se puede acelerar mas");

                }
                else
                {
                    System.Console.WriteLine($"La nueva velocidad es {VelocidadActual}");
                }
            }
            else
            {
                System.Console.WriteLine("Antes de acelerar, prende el vehiculo");
            }
        }

        public void Frenar()
        {
            if (Encendido)
            {
                VelocidadActual -= 20;
                if (VelocidadActual > 0)
                {
                    System.Console.WriteLine($"La nueva velocidad es {VelocidadActual}");
                }
                else
                {
                    System.Console.WriteLine($"{TipoVehiculo} ya esta detenido");
                }
            }
            else
            {
                System.Console.WriteLine($"{TipoVehiculo} esta apagado.");
            }
        }
    }
}
