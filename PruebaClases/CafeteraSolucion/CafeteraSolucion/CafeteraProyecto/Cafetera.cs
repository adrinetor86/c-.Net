namespace CafeteraProyecto;

public class Cafetera
{
    
   public double dblCantidadAgua  { get; set; }
   public double dblCantidadCafe { get; set; }
   public double dblCantidadAzucar { get; set; }

   public Cafetera(double dblCantidadAgua, double dblCantidadCafe, double dblCantidadAzucar)
   {
      this.dblCantidadAgua = dblCantidadAgua;
      this.dblCantidadCafe = dblCantidadCafe;
      this.dblCantidadAzucar = dblCantidadAzucar;
   }

   public double AgregarAgua(double dblCantidadAgua)
   {
      this.dblCantidadAgua+=dblCantidadAgua;
      return this.dblCantidadAgua;
   }
   public double AgregarCafe(double dblCantidadCafe)
   {
      this.dblCantidadCafe+=dblCantidadCafe;
      return this.dblCantidadCafe;
   }
   public double AgregarAzucar(double dblCantidadAzucar)
   {
      this.dblCantidadAzucar+=dblCantidadAzucar;
      return this.dblCantidadAzucar;
   }

   public void PrepararCafe()
   {
      if(this.dblCantidadAgua>=200 && this.dblCantidadCafe>=15)
      {
         Console.WriteLine("Preparando cafe");
      }
      else
      {
         Console.WriteLine("Faltan ingredientes para preparar el cafe");
      }
   }
}