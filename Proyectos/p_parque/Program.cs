using p_parque.Clases;

namespace p_parque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random nro_alea = new Random();

            List<Atraccion> l_atracciones = new List<Atraccion>();
            List<Manilla> l_manillas_vend = new List<Manilla>();

            l_atracciones.Add(new Atraccion("HUlk", 30, new TimeSpan(0, 1, 50)));
            l_atracciones.Add(new Atraccion("Krater", 30, new TimeSpan(0, 1, 20)));
            l_atracciones.Add(new Atraccion("Karts Sencillos", 20, new TimeSpan(0, 5, 0)));
            l_atracciones.Add(new Atraccion("Montaña Acuática", 25, new TimeSpan(0, 3, 0)));
            l_atracciones.Add(new Atraccion("Ciclón", 15, new TimeSpan(0, 2, 0)));

            Parque parque_nor = new Parque("Parque Norte",l_atracciones);

            Console.WriteLine("Cuantas taquillas tiene " + parque_nor.Nombre + ":" + parque_nor.L_taquillas.Count);
            Console.WriteLine("Cuantas manillas tiene la taquilla " + parque_nor.L_taquillas[0].Id + 
                "-->" + parque_nor.L_taquillas[0].L_manillas.Count);

            //vender manillas 
            for(byte i = 1; i<=60; i++)
            {
                l_manillas_vend.Add(parque_nor.L_taquillas[nro_alea.Next(0,3)].
                    Vender_manilla((ulong)nro_alea.Next(20,400)*1000));
            }

            Console.WriteLine("Cuantas manillas tiene la taquilla " + parque_nor.L_taquillas[0].Id +
                "-->" + parque_nor.L_taquillas[0].L_manillas.Count);
            Console.WriteLine("Cuantas manillas tiene la taquilla " + parque_nor.L_taquillas[1].Id +
                "-->" + parque_nor.L_taquillas[1].L_manillas.Count);
            Console.WriteLine("Cuantas manillas tiene la taquilla " + parque_nor.L_taquillas[2].Id +
                "-->" + parque_nor.L_taquillas[2].L_manillas.Count);

            //imprimir la lista de manillas vendidas
            foreach(Manilla manilla in l_manillas_vend)
            {
                Console.WriteLine(manilla.Id + " saldo: " + manilla.Sdo_ptos);
            }

            parque_nor.L_atracciones[3].Descontar_puntos(l_manillas_vend[0], parque_nor);
            parque_nor.L_atracciones[3].Descontar_puntos(l_manillas_vend[1], parque_nor);
            parque_nor.L_atracciones[3].Descontar_puntos(l_manillas_vend[2], parque_nor);

            //imprimir la lista de manillas vendidas
            Console.WriteLine("*********************************************************");
            foreach (Manilla manilla in l_manillas_vend)
            {
                Console.WriteLine(manilla.Id + " saldo: " + manilla.Sdo_ptos);
            }



        }
    }
}