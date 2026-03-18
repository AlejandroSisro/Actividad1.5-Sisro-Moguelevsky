namespace Actividad1._5.Sisro_Moguelevsky;

class Program
{
    static void Main(string[] args)
    {
    Alumno alumno = new alumno();
    Curso curso = new Curso();
    int opcion = 0;
    do
    {
    String[] menu = {"1. Agregar nuevos alumnos","2. Buscar un alumno por su dni", "3. Agregar una falta o media falta a un alumno.", "4.Mostrar todos los alumnos", "5. Mostrar los alumnos con mas de 15 faltas (Libres)"};
    for(int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine(menu[i]);
    }
    opcion = IngresarInt("Ingresa la opcion que desea utilizar del menu", 1, 5);
    switch(opcion){

        case 1:
        {
            bool agregar = curso.AgregarAlumno(alumno);
            if(agregar = true)
            {
                Console.WriteLine("No se pudo agregar al alumno");
            }
            else
            {
                Console.WriteLine("Si se pudo agregar al alumno");
            }
            break;
        }
        case 2:
        {
            bool buscar = curso.BuscarAlumno(alumno);
            if(buscar = true)
            {
                Console.WriteLine(alumno.getNombre());
            }
            break;
        }
        case 3:
        {
            alumno.agregarFalta(double opcion);
            break;
        }
        case 4:
        {
            curso.MostrarAlumnos();
            break;
        }
        case 5:
        {
            curso.MostrarAlumnosCon15Faltas();
            break;
        }
    
                }
    Console.Clear();
    }
    while(opcion != 6);
}
    static double IngresarOpcion()
    {
        double opcion;
        Console.WriteLine("Ingresar 1 si el alumno falto e ingresar 0.5 si el alumno llego tarde");
        do
        {
            opcion = int.Parse(Console.ReadLine());
        }
        while(opcion != 0.5 || opcion != 1);
        return opcion;
    }

    }


