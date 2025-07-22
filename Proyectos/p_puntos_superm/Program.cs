namespace p_puntos_superm
{
    //Este es un programa basado en programación modular o por funciones. 
    //El reto es usar los conceptos del repaso para mejorarlo.
    //Controlando los errores tanto en el programa principal como en las funciones. En estas últimas los errores deben ser arrojados al main
    //quien será el único que los podrá escribir
    //Eliminando todos los Console de las funciones


    internal class Program
    {
        // Constantes Globales
        const ushort PesosPorPunto = 500;
        const byte CantCajasPorSuper = 4;

        // Variables globales
        static List<ulong> saldosVentas = new List<ulong>();
        static List<(uint id, string nombre, ulong telefono, string direccion, ulong saldoPuntos)> clientes = new List<(uint, string, ulong, string, ulong)>();
        static List<(ulong min, ulong max, string descripcion)> premios = new List<(ulong, ulong, string)>();
        static List<(int caja, uint clienteId, ulong compra, ulong puntos, DateTime fecha)> registros = new List<(int, uint, ulong, ulong, DateTime)>();
        static bool[] cajasAbiertas = new bool[CantCajasPorSuper];


        static void Main(string[] args)
        {
            // Simulación de uso
            AbrirCaja(0);
            RegistrarCliente(1, "Ana", 3210001111, "Calle 1");
            RegistrarCliente(2, "Luis", 3210002222, "Calle 2");
            AdicionarPremio(100, 500, "Descuento 5%");
            AdicionarPremio(501, 1000, "Descuento 10%");

            RegistrarCompra(0, 1, 25000); // Caja 0, cliente 1
            RegistrarCompra(0, 2, 60000); // Caja 0, cliente 2

            Console.WriteLine(ConsultarPremios(1));
            Console.WriteLine(CerrarCaja(0));
        }

        static void AbrirCaja(int numeroCaja)
        {
            if (numeroCaja < 0 || numeroCaja >= CantCajasPorSuper)
            {
                Console.WriteLine("Número de caja inválido");
                return;
            }

            if (!cajasAbiertas[numeroCaja])
            {
                cajasAbiertas[numeroCaja] = true;
                saldosVentas.Insert(numeroCaja, 0);
                Console.WriteLine($"Caja {numeroCaja} abierta");
            }
            else
            {
                Console.WriteLine($"Caja {numeroCaja} ya estaba abierta");
            }
        }

        static string CerrarCaja(int numeroCaja)
        {
            if (!cajasAbiertas[numeroCaja])
                return $"La caja {numeroCaja} ya está cerrada";

            ulong saldo = saldosVentas[numeroCaja];
            cajasAbiertas[numeroCaja] = false;
            saldosVentas[numeroCaja] = 0;

            return $"Se recogió en la caja {numeroCaja}: {saldo:C2}";
        }

        static void RegistrarCliente(uint id, string nombre, ulong telefono, string direccion)
        {
            clientes.Add((id, nombre, telefono, direccion, 0));
        }

        static void AdicionarPremio(ulong ptosMin, ulong ptosMax, string descripcion)
        {
            premios.Add((ptosMin, ptosMax, descripcion));
        }

        static void RegistrarCompra(int numeroCaja, uint clienteId, ulong valorCompra)
        {
            if (!cajasAbiertas[numeroCaja])
            {
                Console.WriteLine($"No se puede registrar la compra: caja {numeroCaja} está cerrada.");
                return;
            }

            var indexCliente = clientes.FindIndex(c => c.id == clienteId);
            if (indexCliente == -1)
            {
                Console.WriteLine("Cliente no encontrado");
                return;
            }

            ulong puntosGanados = valorCompra / PesosPorPunto;
            clientes[indexCliente] = (
                clientes[indexCliente].id,
                clientes[indexCliente].nombre,
                clientes[indexCliente].telefono,
                clientes[indexCliente].direccion,
                clientes[indexCliente].saldoPuntos + puntosGanados
            );

            saldosVentas[numeroCaja] += valorCompra;
            registros.Add((numeroCaja, clienteId, valorCompra, puntosGanados, DateTime.Now));

            Console.WriteLine($"Compra registrada: Cliente {clienteId}, Puntos ganados {puntosGanados}");
        }

        static string ConsultarPremios(uint clienteId)
        {
            var cliente = clientes.Find(c => c.id == clienteId);
            if (cliente.id == 0)
                return "Cliente no encontrado";

            string resultado = $"El cliente {cliente.nombre} puede reclamar con {cliente.saldoPuntos} puntos:\n";

            foreach (var premio in premios)
            {
                if (cliente.saldoPuntos >= premio.min && cliente.saldoPuntos <= premio.max)
                    resultado += $"- {premio.descripcion}\n";
            }

            return resultado;
        }


    }
}
