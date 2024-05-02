using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class GestorRecursosHumanos
    {
        public void CalcularPago(Empleado empleado,ITipoEmpleado tipoEmpleado,int horasTrabajadas)
        {
            tipoEmpleado.CalculoSueldo(empleado, horasTrabajadas);
            tipoEmpleado.CalcularBonificacion(empleado, horasTrabajadas);
        }
    }
}
