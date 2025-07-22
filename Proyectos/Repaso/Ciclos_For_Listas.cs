//Ciclos
//Facilitar la ejecución de instrucciones un número 
//determinado de veces --> control.. 

//Necesito pedir 10 números y sumarlos

//For --> Es posible saber hasta va el ciclo
//Es posible programar el incremento o el decremento

uint resultado = 0;

for(int i = 1; i<=10; i++)
{
    Console.WriteLine("Digite un número ");
    resultado += uint.Parse(Console.ReadLine());
}

uint numero1;
string numero;

for (int i = 1; i <= 10; i++)
{
    numero1 = 0;
    Console.WriteLine($" ingrese numero {i}");
    numero = Console.ReadLine();
    
    if (uint.TryParse(numero, out numero1))
        resultado += numero1;
    else
    {
        Console.WriteLine("el numero no es valido ,ingrese denuevo");
        i--;
    }
}

Console.WriteLine("El resultado es: \n" + resultado);

//Listas: colecciones enumerables de elementos que pueden crecer o decrecer

List<string> l_automoviles = new List<string>();

//Adicionar elementos --> Add
l_automoviles.Add("Porshe");
l_automoviles.Add("Maserati");

//Para recorrer una lista se puede con un for o con foreach, mejor usar foreach

foreach(string elemento in l_automoviles)
{
    Console.WriteLine(elemento);
}

l_automoviles.Add("Rover");
l_automoviles.Sort();

foreach (string elemento in l_automoviles)
{
    Console.WriteLine(elemento);
}

//Listas con múltiples tipos de datos.. esto se conoce como lista tuplas

List<(uint id, string nombre, ulong telefono, string direccion, ulong saldoPuntos)> clientes = new List<(uint, string, ulong, string, ulong)>();
clientes.Add((1, "Ana", 3210001111, "Calle 1", 100));
clientes.Add((2, "Luis", 3210002222, "Calle 2", 200));
clientes.Add((3, "Maria", 3210003333, "Calle 3", 300));

var indexCliente = clientes.FindIndex(c => c.id == 3);

if (indexCliente == -1)
    Console.WriteLine("Cliente no encontrado");
else
{
    var cliente = clientes[indexCliente];
    Console.WriteLine($"Cliente encontrado: {cliente.nombre}, Teléfono: {cliente.telefono}, Dirección: {cliente.direccion}, Saldo de Puntos: {cliente.saldoPuntos}");
}

