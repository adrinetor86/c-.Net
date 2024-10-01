using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HolaMundoProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //var variable1 = Console.ReadLine();

            Console.WriteLine("Introduce un numero: ");
            //Convierte el dato recogido en un numero
            int numeroIntroducido =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El numero introducido es: "+ numeroIntroducido);
      
            Console.WriteLine("La tabla del " +numeroIntroducido +":");
            
                for (int i = 1; i <= 10; i++)
                {

                    //Console.WriteLine("El resultado de multiplicar " + numeroIntroducido + " y 100 da: " + 100 * numeroIntroducido);
                    Console.WriteLine(numeroIntroducido + "x" + i + " = " + numeroIntroducido * i);

                }

            //string[] cadenaArr=["e","fe"];
            //Asigno un array de indice 3
            string[] cadenaArr= new string[3];
            cadenaArr[0] = "perro";
            cadenaArr[1] = "gato";
            cadenaArr[2] = "pajarro";

            Console.WriteLine("Navegando por el array ");

            //foreach (string str in cadenaArr)
            //{

            //    Console.WriteLine(str);
            //}
            for (int j = 0; j <= cadenaArr.Length; j++)
            {
                Console.WriteLine(j);
                Console.WriteLine(cadenaArr[j]);

            }

            //metodo(numeroIntroducido);


        }
        static void metodo(int data)
        {
            Console.WriteLine("Ha entrado en el metodo");
            for (int i = 0; i <= data; i++)
            {

                Console.WriteLine(i);
            }

        }
    }
}
