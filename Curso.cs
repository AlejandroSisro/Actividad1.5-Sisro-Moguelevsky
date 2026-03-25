public class Curso
{
    private List<Alumno> alumnos;

    public Curso()
    {
        alumnos = new List<Alumno>();
    }
    public bool AgregarAlumno(Alumno alumno)
    {
        int i = 0;
        bool alumnoEncontrado = false;
        while (i < alumnos.Count && alumnoEncontrado == false)
        {
            if (alumno.obtenerDNI() == alumnos[i].obtenerDNI())
            {
                alumnoEncontrado = true;
            }
            i++;
        }
        if (alumnoEncontrado == false)
        {
            alumnos.Add(alumno);
        }
        return alumnoEncontrado;
    }
    public bool BuscarAlumno(Alumno alumno)
    {
        int i = 0;
        bool alumnoEncontrado = false;
        while (i < alumnos.Count && alumnoEncontrado == false)
        {
            if (alumno.obtenerDNI() == alumnos[i].obtenerDNI())
            {
                alumnoEncontrado = true;
            }
            i++;
        }
        return alumnoEncontrado;
    }
    public void MostrarAlumnos()
    {
        for(int i = 0; i < alumnos.count; i++)
        {
            Console.WriteLine(alumnos[i].getNombre());
        }
    }
    public void MostrarAlumnosCon15Faltas()
    {
        int i = 0;

        while (i < alumnos.Count)
        {
            if (alumnos[i].obtenerFaltas() = 15)
            {
                Console.WriteLine(alumnos[i].getNombre());
            }
            i++;
        }
    }
}
