using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0410.model
{
    class Persona
    {
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string value)
        {
            nombre = value;
        }

        public void mostrarInfo()
        {
            Console.WriteLine("La persona se llama {0}", nombre);
        }
    }
}
