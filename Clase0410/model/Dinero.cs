using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0410.model
{
    class Dinero
    {
        protected int valor;
        protected string valorEnPalabras;
        protected string color;

        public Dinero()
        {

        }

        public Dinero(int valor, string valorEnPalabras, string color)
        {
            this.valor = valor;
            this.valorEnPalabras = valorEnPalabras;
            this.color = color;
        }

        public int Valor { get => valor; set => valor = value; }
        public string ValorEnPalabras { get => valorEnPalabras; set => valorEnPalabras = value; }
        public string Color { get => color; set => color = value; }

        public void mostrarInfo()
        {
            Console.WriteLine("Este tipo de dinero tiene un valor de {0} ( {1} ) y es de color {2}", valor, valorEnPalabras, color);
        }
    }
}
