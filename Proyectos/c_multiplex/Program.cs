using b_multiplex.Clases;

namespace c_multiplex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Taquillero taq_arroyave = new Taquillero("Andres Arroyave", 1999888777, 3119876542);
                Pelicula cap_ame = new Pelicula("American Captain", "Capitán América", new TimeSpan(2, 0, 0), 15);
                Sala sala1 = new Sala(1, 30, 60);
                Funcion f1 = new Funcion(sala1, cap_ame, new DateTime(2025, 3, 27, 2, 0, 0));
                Taquilla ta1 = new Taquilla(1, taq_arroyave);
                Multiplex unicentro = new Multiplex("Unicentro");
                Socio mesa = new Socio("Juan jose Mesa",122334455,3014356781);

                Console.WriteLine(ta1.Vender_boleta(f1, 6, Multiplex.tipo_sillas.V,mesa));


            }

            catch(Exception err) 
            { 
                Console.WriteLine(err.ToString());
            }
        }
    }
}