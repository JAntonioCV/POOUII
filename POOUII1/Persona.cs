using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUII1
{
    //Clase Persona
    internal class Persona
    {
        //Campos estaticos
        public static int ContadorPersona = 0;
        public static readonly double PI = 3.1416;

        //Atributos o propiedades
        private string _Cedula;
        private string _Nombres;
        private string _Apellidos;
        private int _Edad;
        private double _Peso;

        //Metodos getter y setter que sirven para leer y escribir propiedades privadas
        public double Peso
        {
            get { return _Peso; }
            set { _Peso = value; }
        }

        public int Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }
        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        public string Cedula
        {
            get { return _Cedula; }
            set { _Cedula = value; }
        }

        //Propiedades Autoimplementadas
        public bool EsEstudiante { get; set; }
        public char Genero { get; set; }

        //Constructor por Defecto
        public Persona()
        {
            ContadorPersona++;
        }

        //Sobrecarga de metodos construir
        public Persona(string cedula, string nombres, string apellidos, int edad, double peso, bool EsEstudiante, char genero)
        {

            _Cedula = cedula;
            _Nombres = nombres;
            _Apellidos = apellidos;
            _Edad = edad;
            _Peso = peso;
            this.EsEstudiante = EsEstudiante;
            Genero = genero;
            ContadorPersona++;
        }

        //Metodos 
        public void Saludar()
        {
            Console.WriteLine("Hola Mundo " + _Nombres);
        }

        //Metodos sobreCargados
        public void Saludar(string nombre)
        {
            Console.WriteLine("Hola Mundo {0} yo soy {1} persona", nombre, _Nombres);
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Cedula: {_Cedula}, Nombres: {_Nombres}, Edad: {_Edad}, Peso: {_Peso}, Estudiante: {EsEstudiante}, Genero: {Genero}");
        }

        //Metodos Estaticos
        public static void MostrarPI()
        {
            Console.WriteLine("El valor de PI es: " + PI);
        }

        public static void CantidadDePersonas()
        {
            Console.WriteLine("La cantidad de persona es: {0}", ContadorPersona);
        }



        }

    }

    
