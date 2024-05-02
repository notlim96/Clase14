using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class EmpleadoPorProyecto : ITipoEmpleado
    {
        public double SueldoTotal { get; set; }
        public double Bonficacion { get; set; }
        public void CalcularBonificacion(Empleado empleado, int horasTrabajadas)
        {
            Bonficacion = 0;
            Console.WriteLine("********************   BONIFICACION **************");
            Console.WriteLine("Empleado Por Proyecto");
            Console.WriteLine($"Nombre: {empleado.Id}");
            Console.WriteLine($"Costo: {empleado.Nombre}");
            Console.WriteLine($"Sueldo Base: {empleado.SueldoBase}");
            Console.WriteLine($"Bonificacion: {Bonficacion}");
        }

        public void CalculoSueldo(Empleado empleado, int horasTrabajadas)
        {
            SueldoTotal = empleado.SueldoBase * horasTrabajadas;
            Console.WriteLine("**********  SUELDO ******************");
            Console.WriteLine("Empleado Por Proyecto");
            Console.WriteLine($"Nombre: {empleado.Id}");
            Console.WriteLine($"Costo: {empleado.Nombre}");
            Console.WriteLine($"Sueldo Base: {empleado.SueldoBase}");
            Console.WriteLine($"Sueldo Total: {SueldoTotal}");
        }
    }
}
