using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProfesores
{
    public class Profesor: Empleado
    {
        public int HorasSemanales {  get; set; }

        public Profesor(
            string nombre,
            string apellido,
            int edad,
            string dni,
            string genero,
            string puesto,
            string antiguedad,
            string sueldo,
            int horasSemanales)
            : base(nombre, apellido, edad, dni, genero, puesto, antiguedad, sueldo)
        {
            HorasSemanales = horasSemanales;
        }
        public void AgregarHoras(int horas)
        {
            if (horas > 0)
            {
                HorasSemanales += horas;
                Console.WriteLine($"Se han agregado {horas} horas. Total de horas: {HorasSemanales}");
            }
            else
            {
                Console.WriteLine("La cantidad de horas a agregar debe ser mayor que 0.");
            }
        }

        public void RestarHoras(int horas)
        {
            if (horas > 0 && horas <= HorasSemanales)
            {
                HorasSemanales -= horas;
                Console.WriteLine($"Se han restado {horas} horas. Total de horas: {HorasSemanales}");
            }
            else if (horas <= 0)
            {
                Console.WriteLine("La cantidad de horas a restar debe ser mayor que 0.");
            }
            else
            {
                Console.WriteLine("La cantidad de horas a restar es mayor que las horas trabajadas.");
            }
        }
        public override string IrAlTrabajo()
        {
            return $"El profesor {Nombre} está yendo al trabajo.";
        }
        public override bool Retirarse()
        { return false; }
        public override void HolaSoy() {}
        public override void MiDniEs() { }
    }
}
