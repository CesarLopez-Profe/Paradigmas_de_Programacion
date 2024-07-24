using p_bicicleta.Clases;

namespace p_bicicleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciar: crear un objeto de una clase

            Bicicleta mi_bici1 = new Bicicleta();
            mi_bici1.material = Bicicleta.l_materiales.Fibra;
            mi_bici1.tam_llanta = 5.2f;
            mi_bici1.color = Bicicleta.l_colores.Rojo;
            mi_bici1.marca = "GW";
            mi_bici1.nro_cambios = 8;

            Console.WriteLine("La bicicleta va en: " + mi_bici1.cambio_actual);

            for (byte i=1; i<=mi_bici1.nro_cambios+1; i++)
            {
                mi_bici1.Subir_cambio();
                Console.WriteLine("La bicicleta va en: " + mi_bici1.cambio_actual);
            }


        }
    }
}