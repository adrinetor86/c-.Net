namespace EmpleadosProyecto;

public class Empleado
{
    public string strNombre { get; set; }
    public string strTrabajo { get; set; }

    public Empleado(string strNombre, string strTrabajo)
    {
        this.strNombre = strNombre;
        this.strTrabajo = strTrabajo;
    }

    public string getNombre()
    {
        return this.strNombre;
    }
    public void setNombre(string strNombreEmpleado)
    {
        this.strNombre = strNombreEmpleado;
    }
    
    public string getTrabajo()
    {
        return this.strTrabajo;
    }
    public void setTrabajo(string strTrabajoEmpleado)
    {
        this.strNombre = strTrabajoEmpleado;
    }
}