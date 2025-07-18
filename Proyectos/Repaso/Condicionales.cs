//Condicionales
bool condicion = true;

//if else: condiciones son compuestas, una opción por el verdadero
//una opción por el falso
if (!condicion) Console.WriteLine("La variable es verdadera");
else Console.WriteLine("La variable es falsa");



//if - else if - else
//condiciones son compuestas (> <= < == != && || ) y tengo que validar muchas combinaciones
//de esas condiciones
Console.Write("Ingrese un caracter:  ");
//char caracter = (char)Console.Read();
char caracter = Convert.ToChar(Console.ReadLine());


//El caracter ingresado es de qué tipo?
if (char.IsUpper(caracter)) Console.WriteLine("El caracter es una letra mayúscula");
else if (char.IsLower(caracter)) Console.WriteLine("El caracter es una letra minúscula");
else if (char.IsDigit(caracter)) Console.WriteLine("El caracter es un dígito");
else Console.WriteLine("El caracter puede ser un símbolo o algo más");

//switche
//Cuando se va a evaluar el valor de una sola variable
//en multiples casos (==). 
Console.WriteLine("Ingrese un color:  ");
string color = Console.ReadLine();

switch (color.ToUpper())
{
    case "AZUL":
        Console.WriteLine("El color es Azul");
        break;

    case "ROJO":
        Console.WriteLine("El color es Rojo");
        break;

    case "AMARILLO":
        Console.WriteLine("El color es Amarillo");
        break;

    default: //cualquier otro caso
        Console.WriteLine("El color no está en la lista");
        break;
}