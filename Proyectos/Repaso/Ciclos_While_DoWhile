//While
byte i = 1;
uint numero1;
string numero;

//se usa generalmente cuando no se sabe hasta 
//donde llegar, para leer archivos
//Valida la condición y entra

while (i<=10)
{
    numero1 = 0;
    Console.WriteLine($" ingrese numero {i}");
    numero = Console.ReadLine();

    if (uint.TryParse(numero, out numero1))
    {
        resultado += numero1;
        i++;
    }
    else
        Console.WriteLine("el numero no es valido ,ingrese denuevo");
}


//do while
//Se usa cuando se quiere ejecutar por lo menos 
//una vez las instrucciones que hay dentro del ciclo
//se usa para hacer menús

byte i = 1;
uint numero1;
string numero;

do
{
    numero1 = 0;
    Console.WriteLine($" ingrese numero {i}");
    numero = Console.ReadLine();

    if (uint.TryParse(numero, out numero1))
    {
        resultado += numero1;
        i++;
    }
    else
        //Console.WriteLine("el numero no es valido ,ingrese de nuevo");
        throw new Exception("el numero no es valido ,ingrese de nuevo");
 } while (i <= 10);