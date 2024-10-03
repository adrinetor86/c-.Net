namespace LibrosProyecto;

public class Libro
{
    public string strTitulo { get; set; }
    public string strAutor { get; set; }
    public int intNumPagina { get; set; }


    public Libro(string strTitulo, string strAutor, int intNumPagina)
    {
        this.strTitulo=strTitulo;
        this.strAutor=strAutor;
        this.intNumPagina=intNumPagina;
        
        
    }
    
    public void MostrarDetalles()
    {
        Console.WriteLine($"Titulo: {strTitulo}\n" +
                          $"Autor: {strAutor}\n" +
                          $"Paginas: {intNumPagina}");
    }

    
    
    public bool EsLargo(int numeroPagina)
    {
        if (numeroPagina > 300)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}