namespace CocheNameSpace
{
    
    public class Coche
    {
        public string strMarca { get; set; }
        public double dblPrecio { get; set; }

        public Coche(string Marca, double Precio)
        {
            this.strMarca = Marca;
            this.dblPrecio = Precio;
        }

        public double Precio
        {
            get { return dblPrecio; }
            set { dblPrecio = value; }
        }

    }
}