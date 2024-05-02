
using Examen;

GestorRecursosHumanos gestorRecursos = new GestorRecursosHumanos();

Empleado empleado = new Empleado
{
    Id = 1,
    Nombre = "Juan",
    SueldoBase = 100
};

Empleado empleado2 = new Empleado
{
    Id = 2,
    Nombre = "Maria",
    SueldoBase = 100
};


gestorRecursos.CalcularPago(empleado,new EmpleadoTiempoCompleto(), 10);
gestorRecursos.CalcularPago(empleado2,new EmpleadoPorProyecto(),5);
