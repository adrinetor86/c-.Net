namespace BancoProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {

           var numeroCliente= EscogerCliente();
        //Definimos un array bidimensional
           int[,] cuentasBancarias = new int[2,1];
           
            cuentasBancarias[0,0]=2000;
            cuentasBancarias[1,0]=6000;
            
            Console.WriteLine("Cliente: "+cuentasBancarias[numeroCliente,0]);
            
            Console.WriteLine("ESCOGE UNA OPCION:\n" +
                "1) Meter dinero en la cuenta\n" +
                "2) Sacar dinero de la cuenta");

            var opcion = int.Parse(Console.ReadLine());
            
            bool blnBandera = false;
            //Si añado la D le digo q esa variable sera un double
            var cantidadDinero = 5000D;
            
            do
            {
                switch (opcion)
                {
                    case 1:
                        cantidadDinero= MeterDinero(cantidadDinero);
                        opcion= Menu();
                        blnBandera = true;
                        break;
                    case 2:
                        cantidadDinero=SacarDinero(cantidadDinero);
                        opcion= Menu();
                        blnBandera = true;
                        break;
                    case 3:
                        MostrarDinero(cantidadDinero);
                        opcion= Menu();
                        blnBandera = true;
                        break;
                    default:
                        Console.WriteLine("ESCOGE UNA OPCION:\n" +
                       "1) Meter dinero en la cuenta\n" +
                       "2) Sacar dinero de la cuenta\n" +
                       "3) Salir del programa");
                        opcion = int.Parse(Console.ReadLine());
                        blnBandera = false;
                        break;
                }
            } while (opcion!=4);
        }

        public static int EscogerCliente()
        {
            Console.WriteLine("Que id de cliente tines? (1 o 2)");
            var numCliente = int.Parse(Console.ReadLine());
            return numCliente;
        }
        public static int Menu()
        {
            Console.WriteLine("ESCOGE UNA OPCION:\n" +
                             "1) Meter dinero en la cuenta\n" +
                             "2) Sacar dinero de la cuenta\n" +
                             "3) Ver dinero disponible\n" +
                             "4) Salir del programa");
            
            var opcion = int.Parse(Console.ReadLine());
            return opcion;
        }
        public static double MeterDinero(double cantidadDinero)
        {
            Console.WriteLine("Cuanto dinero quieres meter?");
            var valorDineroMetido = double.Parse(Console.ReadLine());
            
            cantidadDinero += valorDineroMetido;
            return cantidadDinero;
        }

        public static double SacarDinero(double cantidadDinero)
        {
            Console.WriteLine("Cuanto dinero quieres sacar?");
            var valorDineroSacado = double.Parse(Console.ReadLine());
            return valorDineroSacado;
        }

        public static void MostrarDinero(double cantidadDinero)
        {
            
            Console.WriteLine("******************************************************\n"+
                              "***                                                ***\n"+
                              "*** TU CUENTA CORRIENTE ES "+ cantidadDinero +"    ***\n"+
                              "***                                                ***\n"+
                              "******************************************************");
        }
    }
}
