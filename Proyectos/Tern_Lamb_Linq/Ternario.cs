
//Ternario con var
int numero = -5;
var resultado = (numero >= 0) ? "Positivo" : "Negativo";
Console.WriteLine(resultado);

//******
short precio = 120;
bool aplicaDescuento = true;
var precioFinal = aplicaDescuento ? precio * 0.85m : precio;
Console.WriteLine(precioFinal);
Console.WriteLine(precioFinal.GetType()); // Averiguar el tipo de dato de var, en este caso: System.Decimal


//******
int edad = 70;

var categoria = (edad < 18) ? "Menor" :
                (edad <= 60) ? "Adulto" :
                "Adulto Mayor";

Console.WriteLine(categoria); 

//Ternario con Funciones Lambda
//********
Func<int, string> parOImpar = num => (num % 2 == 0) ? "Par" : "Impar";
Console.WriteLine(parOImpar(4));  // Salida: Par
Console.WriteLine(parOImpar(7));  // Salida: Impar

//********
Func<decimal, bool, decimal> aplicarDescuento = (precio, tieneDescuento) =>
    tieneDescuento ? precio * 0.9m : precio;

Console.WriteLine(aplicarDescuento(100m, true));   // Salida: 90
Console.WriteLine(aplicarDescuento(100m, false));  // Salida: 100

//********
Func<int, int, int> mayor = (a, b) => (a > b) ? a : b;
Console.WriteLine(mayor(10, 20));  // Salida: 20

//********
Func<int, bool> GanaMateria = nota =>
    (nota >= 60) ? true : false;


Console.WriteLine(GanaMateria(75)); // Salida: True
Console.WriteLine(GanaMateria(45)); // Salida: False

//Ternaria Anidada
Func<int, string> mensajeEdad = edad =>
    (edad < 18) ? "Menor de edad" :
    (edad <= 60) ? "Adulto" : "Adulto mayor";

Console.WriteLine(mensajeEdad(16));  // Salida: Menor de edad
Console.WriteLine(mensajeEdad(30));  // Salida: Adulto 
Console.WriteLine(mensajeEdad(65));  // Salida: Adulto mayor