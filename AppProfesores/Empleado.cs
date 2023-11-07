using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProfesores
{
    public abstract class Empleado: Persona
    {
        public string Puesto {  get; set; }
        public string Antiguedad { get; set; }
        public string Sueldo { get; set; }

        public Empleado(string nombre, 
                        string apellido, 
                        int edad, 
                        string dni,
                        string genero, 
                        string puesto, 
                        string antiguedad,
                        string sueldo)
            : base (nombre, apellido, edad, dni, genero)
        {
            Puesto = puesto;
            Antiguedad = antiguedad;
            Sueldo = sueldo;
        }
        public abstract string IrAlTrabajo();
        public abstract bool Retirarse();
    }
}
