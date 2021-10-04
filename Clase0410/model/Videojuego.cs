using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0410.model
{
    class Videojuego
    {
        private string nombre;
        private string color;

        public Videojuego(string nombre, string color)
        {
            this.nombre = nombre;
            this.color = color;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Color { get => color; set => color = value; }
    }
}
