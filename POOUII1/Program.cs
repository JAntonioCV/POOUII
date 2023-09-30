using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUII1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("La Cantidad de Personas Instaciadas: " + Persona.ContadorPersona);
            //Console.WriteLine("El valor de PI es: " + Persona.PI);
            //Persona.ContadorPersona = 100;
            //Console.WriteLine("La Cantidad de Personas Instaciadas: " + Persona.ContadorPersona);

            Persona persona1 = new Persona();

            persona1.Cedula = "001-100799-0000V";
            persona1.Nombres = "Pedro Pablo";
            persona1.Apellidos = "Martinez Gutierrez";
            persona1.Edad = 24;
            persona1.Peso = 165.8;
            persona1.EsEstudiante = false;
            persona1.Genero = 'M';

            //Console.WriteLine("La Cantidad de Personas Instaciadas: " + Persona.ContadorPersona);

            Persona persona2 = new Persona("570-100798-11124Q", "Juana Maria", "Perez Zeledon", 50, 120.5, true, 'F');

            //Console.WriteLine("Persona 2 Agregada");

            //Console.WriteLine("La Cantidad de Personas Instaciadas: " + Persona.ContadorPersona);

            //persona1.Saludar();
            //persona2.Saludar();

            //persona1.Saludar("Pepito");
            //persona2.Saludar("Violeta");

            //persona1.MostrarInformacion();
            //persona2.MostrarInformacion();

            Persona.MostrarPI();
            Persona.CantidadDePersonas();


            Console.ReadLine();
        }
    }
}
