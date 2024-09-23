using p_estudiantes.Clases;

namespace p_estudiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Posgrado canito = new Posgrado();

            Console.WriteLine (canito.Escribir_tesis());
            Console.WriteLine(canito.Matricular_materias());
            Console.WriteLine(canito.Estudiar());
            Console.WriteLine(canito.Sustentar_tesis());
            Console.WriteLine(canito.Exponer());


        }
    }
}