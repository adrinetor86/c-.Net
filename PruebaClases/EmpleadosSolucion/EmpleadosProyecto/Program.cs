// See https://aka.ms/new-console-template for more information
using EmpleadosProyecto;



Console.WriteLine("Cuantos empleados hay?");
var numeroEmpleados =int.Parse(Console.ReadLine());

for (int i = 0; i < numeroEmpleados; i++)
{
    
}
Empleado empleado1 = new Empleado("Pedro","IT");
Empleado empleado2 = new Empleado("Maria","Desarrollo de Apps");
Empleado empleado3 = new Empleado("Juan","RRHH");

Console.WriteLine("EMPLEADO 1-> " + empleado1.getNombre() + " trabaja en  " + empleado1.getTrabajo() + "\n" +
                  "EMPLEADO 2-> " + empleado2.getNombre() + " trabaja en  " + empleado2.getTrabajo() + "\n" +
                  "EMPLEADO 3-> " + empleado3.getNombre() + " trabaja en  " + empleado3.getTrabajo());
