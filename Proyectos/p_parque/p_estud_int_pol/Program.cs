using p_estud_int_pol.Clases;

namespace p_estud_int_pol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posgrado andres = new Posgrado("Andres", "Maestría en Transformación Digital");

            andres.Estudiar();
            andres.Exponer("Como comer gratis en los casinos de unicentro");
            andres.EscribirTesis("Impacto de la POO en la arqu de software");
            Console.WriteLine($"{andres.nombre} sustentó la tesis y ganó? {andres.SustentarTesis(new DateTime(2025, 12, 1))}");


        }
    }
}