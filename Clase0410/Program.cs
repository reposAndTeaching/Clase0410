using Clase0410.model;
using System;

namespace Clase0410
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;

            //declaramos lista/array
            int[] listaNumeros;
            //inicializamos lista/array
            listaNumeros = new int[3];

            //segunda lista, podemos declarar e inicializar en la misma línea
            int[] listaDeNumero2 = new int[5];

            //vemos el valor de la lista según su índice
            Console.WriteLine(listaNumeros[0]);
            Console.WriteLine(listaNumeros[1]);
            Console.WriteLine(listaNumeros[2]);

            //seteamos valores de la lista según el índice
            listaNumeros[0] = 12;
            listaNumeros[1] = 26;
            listaNumeros[2] = 5647;

            //vemos el valor de la lista según su índice
            Console.WriteLine(listaNumeros[0]);
            Console.WriteLine(listaNumeros[1]);
            Console.WriteLine(listaNumeros[2]);

            //salgo del rango y el programa envía una excepción/error
            //listaNumeros[3] = 56;

            //diferentes maneras de declarar e inicializar

            string[] listaNombres = new string[2] { "Juan Pablo", "Diego" };
            string[] listaNombres2 = new string[] { "Juan Pablo", "Diego" };

            Console.WriteLine(listaNombres[0]);
            Console.WriteLine(listaNombres[1]);

            //array implícito, inicialmente no conzco el tipo de dato que guardará la lista, el compilador lo decide en tiempo de compilación/ejecución.
            var arrayImplicito = new[] {1,2,3,4,5 };

            Console.WriteLine(arrayImplicito[0]);
            Console.WriteLine(arrayImplicito[1]);

            //crear un array de objetos

            Videojuego[] misConsolas = new Videojuego[2];
            misConsolas[0] = new Videojuego("Series S", "Blanco");

            Videojuego miVideo = new Videojuego("Play Station 5", "Blanco");
            misConsolas[1] = miVideo;

            Videojuego otraConsola = new Videojuego("Nintendo Switch", "Negro");

            //cree un array de objetos sin conocer el tipo de dato
            var arrayImplicito2 = new[] { miVideo, otraConsola };

            //Puedo escribir la cadena de salida de diferentes maneras, la primera es mediante indicador de posición(String.Format)
            Console.WriteLine("La primera consola es una {0} y es de color {1}", misConsolas[0].Nombre, misConsolas[0].Color);
            //ésta manera es concatenando cadenas y variables con un +
            Console.WriteLine("La primera consola es una "+misConsolas[0].Nombre+" y es de color "+misConsolas[0].Color);
            //ésta manera es utilizando un indicador $ al comeienzo para indicar que será una cadena mixta (texto y objetos/variables/funciones/etc) y escriben similar al indicador de posición, sería ubicarlos dentro de { }
            Console.WriteLine($"La primera consola es una {misConsolas[0].Nombre} y es de color {misConsolas[0].Color}");

            //array con tipos de datos anónimos
            var arrayConTiposAnonimos = new[]
            {
                new{Nombre="XBOX Series S", Color="Blanco"},//0
                new{Nombre="PS5", Color="Blanco"},//1
                new{Nombre="N. Switch", Color="Negro"}//2
            };

            Console.WriteLine("****");
            //Tenemos funciones y propiedades tambien en arrays, una de ellas es Length, que me permite conocer al cantidad de elementos dentro del array
            Console.WriteLine(misConsolas.Length);

            //entonces para recorrer una lista con un for convencional, iríamos desde 0 hasta el largo de la lista menos 1 (0 hasta lista.Length)
            //Cada vuelta de for, incrementará el valor de i en +1, comenzando de 0, de ésta manera puedo utilizar esta variable para acceder a las posiciones de las listas
            for(int i = 0; i<misConsolas.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("La consola se llama {0} y es de color {1}", misConsolas[i].Nombre, misConsolas[i].Color);
            }

            Console.WriteLine("*****");

            //se puede utilizar un foreach, bucle diseñado para recorrer estructuras de éste tipo.
            //puedo utilizar una variable externa para controlar un índice si así se requiere
            //cada elemento iterado en el foreach (item en este caso), siempre será de solo lectura, por tanto no podremos hacer cambios a ese elemento, en ese caso, debemos utilizar la estructura estudiada en el for convencional
            int _index = 0;
            foreach(var item in misConsolas)
            {
                Console.WriteLine("La consola se llama {0} y es de color {1}", item.Nombre, item.Color);
                //_index = _index + 1;
                //_index++;
                _index += 1;
            }

            Console.WriteLine("********************ACA COMIENZO A VER HERENCIA*****************************");

            Billete luca = new Billete(7, 3, 1000, "Mil", "Verde");

            Console.WriteLine(luca.Ancho);
            Console.WriteLine(luca.Largo);
            Console.WriteLine(luca.Valor);
            Console.WriteLine(luca.ValorEnPalabras);
            Console.WriteLine(luca.Color);


            Dinero dosLucas = new Billete(8, 3 , 2000, "Dos Mil", "Morado");

            luca.mostrarInfo();
            //DRY
            //Dont repeat yourself


            Console.Write("Ingrese cantidad de personas a ingresar: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Persona[] listaDePersonas = new Persona[cantidad];

            for(int i = 0; i<listaDePersonas.Length; i++)
            {
                Console.Write("Ingrese nombre persona {0}: ", i+1);
                string nombrePersona = Console.ReadLine();
                listaDePersonas[i] = new Persona(nombrePersona);
                Console.WriteLine("-------//--------");
            }

            Console.WriteLine("Entonces la lista completa de personas es: ");

            foreach(Persona p in listaDePersonas)
            {
                p.mostrarInfo();
            }
            Console.WriteLine();
        }
    }
}
