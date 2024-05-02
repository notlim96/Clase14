using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public interface ITipoEmpleado
    {
        //  metodos
        public void CalculoSueldo(Empleado empleado, int horasTrabajadas);
        public void CalcularBonificacion(Empleado empleado, int horasTrabajadas);
    }
}
