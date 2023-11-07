using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProfesores
{
    public abstract class Persona
    {  
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Dni { get; set; }
        public string Genero { get; set; }

        public Persona(string nombre, string apellido, int edad, string dni, string genero)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Dni = dni;
            Genero = genero;
        }

        public abstract void HolaSoy();

        public abstract void MiDniEs();
    }
}
