using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0410.model
{
    class Billete : Dinero
    {
        private int largo;
        private int ancho;

        public Billete(int largo, int ancho)
        {
            this.largo = largo;
            this.ancho = ancho;
        }

        public Billete(int largo, int ancho, int valor, string valorEnPalabras, string color) : base(valor, valorEnPalabras, color)
        {
            this.largo = largo;
            this.ancho = ancho;
        }

        public int Largo { get => largo; set => largo = value; }
        public int Ancho { get => ancho; set => ancho = value; }
    }
}
