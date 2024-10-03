// See https://aka.ms/new-console-template for more information

using LibrosProyecto;

Console.WriteLine("Ingrese el Nombre del Libro:");
string strNombre=Console.ReadLine();

Console.WriteLine("Ingrese el Autor del Libro:");
string strAutor=Console.ReadLine();

Console.WriteLine("Ingrese el numero de paginas:");
var intPag=int.Parse(Console.ReadLine());

Libro libro= new Libro(strNombre,strAutor,intPag);

libro.MostrarDetalles();

if (libro.EsLargo(libro.intNumPagina))
{
    Console.WriteLine("El libro es largo");
};




