namespace p_prueba_func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int j = 25;

            //Func<int, int> resultado = i => 100 + i + j;
            //Console.WriteLine(resultado(50));
            /*
            Func<int, bool> isZero = n => n == 0;
            int[] a = { 0, 1, 0, 3, 4, 0 };
            Console.WriteLine(a.Count());
            Console.WriteLine(isZero(a[1]));
            Console.WriteLine(a.Count(isZero));*/

            /* En esta lambda de instrucción que devuelve la función y cómo queda la j?
            j = 6;
            Func<int, int> function = i => {
                j = j * j;
                return 100 + i + j;
            };

            int result = function(50);
            Console.WriteLine(result + " " + j);*/

            /*main
            Cuenta cta = new Cuenta();
            cta.saldo = 300000;
            Console.WriteLine(cta.GetHashCode());
            cta.Depositar(1000000);
            Console.WriteLine(cta.GetHashCode());

            //main
            Console.WriteLine("Inmutable");
            CuentaI ctai = new CuentaI(30000);
            Console.WriteLine(ctai.saldo);
            Console.WriteLine(ctai.GetHashCode());
            ctai = ctai.Depositar(1000000);
            Console.WriteLine(ctai.saldo);
            Console.WriteLine(ctai.GetHashCode());
            ctai = ctai.Depositar(1);
            Console.WriteLine(ctai.saldo);
            Console.WriteLine(ctai.GetHashCode());
            */

            List<Paciente> l_pac = new List<Paciente>() {

                new Paciente("Agudelo",39,5000000),
                new Paciente("Ciro", 80, 9000000),
                new Paciente("Espinosa",25,3000000),
                new Paciente ("Natalia",32,8765000),

            };

            var tot_saldos = l_pac.Sum(elem=>elem.saldo);
            Console.WriteLine("Total saldos: " + tot_saldos);

            var pacxedad = l_pac.OrderBy(elem=>elem.edad).ToList();

            Console.WriteLine("Lista de pacientes por edad");
            pacxedad.ForEach(elem => Console.WriteLine(elem.nombre + " " + elem.edad));

            var consultaEdad = l_pac.Where(elem=>elem.edad ==1).ToList();
            Console.WriteLine(consultaEdad.Count);

            tot_saldos = l_pac.Where(elem => elem.edad >= 18).Sum(elem=>elem.saldo);

            Console.WriteLine("Total saldos: " + tot_saldos);

            Action<Paciente> acc_pac = (Paciente pac_in) =>
            {
                Console.WriteLine($"Action Paciente {pac_in.nombre} Edad {pac_in.edad}");
            };
            Console.WriteLine("Impresión pacxedad con action");
            pacxedad.ForEach(elem => acc_pac(elem));

            l_pac.Where(w => w.edad > 18).ToList().ForEach(elem => elem.nombre = elem.nombre + "-M-");

            l_pac.ForEach(elem => Console.WriteLine(elem.nombre));

        }
    }

    public class Cuenta
    {
        public ulong saldo { get; set; }
        public void Depositar(ulong valor)
        {
            saldo += valor;
        }
    }

    public class CuentaI
    {
        public ulong saldo { get; }
        public CuentaI(ulong saldo)
        {
            this.saldo = saldo;
        }
        public CuentaI Depositar(ulong valor) => new CuentaI(saldo + valor);
    }

    public class Paciente
    {
        internal string nombre;
        internal byte edad;
        internal long saldo;

        public Paciente(string nombre, byte edad, long saldo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.saldo = saldo;
        }
    }




}