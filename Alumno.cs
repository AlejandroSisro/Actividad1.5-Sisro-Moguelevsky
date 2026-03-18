public class Alumno
{
    private int dni;
    private string nombre;
    private double cantidadFaltas;
    public Alumno(int dni, string nombre)
    {
        this.dni=dni;
        this.nombre=nombre;
        this.cantidadFaltas=0;
    }
    public void agregarFalta(double opcion)  
    {
        cantidadFaltas+=opcion;    
    }
    public string getNombre()
    {
        return nombre;
    }
    public int obtenerDNI()
    {
        return dni;
    }
    public double obtenerFaltas()
    {
        return cantidadFaltas;
    }

}
