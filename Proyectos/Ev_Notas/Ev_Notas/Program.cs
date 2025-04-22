using Ev_Notas.Clases;

namespace Ev_Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Registro r1 = new Registro();
                Console.WriteLine("la nota final es: \n" + r1.Calcular_Nota(5,5,5,5));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}