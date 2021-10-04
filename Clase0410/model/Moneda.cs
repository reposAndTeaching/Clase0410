using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0410.model
{
    class Moneda : Dinero
    {
        private double peso;
        private int lados;

        public Moneda(double peso, int lados, int valor, string valorEnPalabrs, string color)
            : base(valor, valorEnPalabrs, color)
        {
            this.peso = peso;
            this.lados = lados;
        }

        public double Peso { get => peso; set => peso = value; }
        public int Lados { get => lados; set => lados = value; }
    }
}
