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

//Listas

List<string> l_automoviles = new List<string>();

//Adicionar elementos --> Add
l_automoviles.Add("Porshe");
l_automoviles.Add("Maserati");

//Para recorrer una lista se puede con un for o con foreach, vamos a usar foreach

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