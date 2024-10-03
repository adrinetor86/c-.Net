// See https://aka.ms/new-console-template for more information
//PONEMOS EL USING Y EL NAMESPACE DE LA CLASE PARA USARLA
using CocheNameSpace;
// namespace ClaseProyecto;

internal class Program
{
    static void Main(string[] args)
    {
     Console.WriteLine("Dime la matricula del coche");   
     string strMatricula = Console.ReadLine();
     
     Console.WriteLine("Dime el precio del coche");
     var dblPrecio = Double.Parse(Console.ReadLine());
     
     Coche coche= new Coche(strMatricula,dblPrecio);

        Console.WriteLine("La marca del coche "+coche.strMarca);
        Console.WriteLine("El precio del coche "+coche.dblPrecio);
        
    }
    
}
