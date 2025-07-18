//Acá encontrarán diferentes tipos de datos en C#
//La forma de hacer conversión de tipos de datos
ushort datpeq1 = 0;
byte datob = 7;

//datob = datpeq1; //no se puede implicitamente
//conversión explicita - cast
datob = (byte)datpeq1;

//reales
float decimal1 = 0;
float decimal2 = 0.6541331F;
float decimal3 = (float)0.6541331;


double real_largo = 115.85123255313;

//Castings de tipos de datos
uint entero1 = (uint)real_largo;
int entero2 = (int)real_largo;
ushort corto1 = (ushort)real_largo;
short corto2 = (short)real_largo;
ulong largo1 = (ulong)real_largo;
long largo2 = (long)real_largo;

//convertir texto a nro --> Parse, poco confiable, se puee quebrar el código fácilmente
string txt1 = "12355321";
decimal1 = float.Parse(txt1);

string txt2 = "abcd";
//uint entero1; // = uint.Parse(txt2);

//tryparse  --> más seguro para convertir texto a número

if (uint.TryParse(txt2, out entero1))
    Console.WriteLine("El entero resultante es " + entero1);
else
    Console.WriteLine("La conversión no se puede hacer");

//averiguar si dos strings son iguales

string txt3 = "Medellín";
string txt4 = "Medellin";

//if (txt3 == txt4) Console.WriteLine("Son iguales"); --> No es buena práctica usar el operador de igualdad para comparar strings

//Se usa equals, como se ve a continuación
if (txt3.Equals(txt4)) Console.WriteLine("Son iguales");
else Console.WriteLine("Son diferentes");

//Tipo de dato  DateTime --> fechas con horas
DateTime fecha1 = DateTime.Today;
Console.WriteLine(fecha1);

DateTime fecha2 = DateTime.Parse("26/07/2021 8:0:0");
Console.WriteLine(fecha2);

DateTime fecha4;
string fecha_txt = "31/5/2021 8:0:0";

if (DateTime.TryParse(fecha_txt, out fecha4))
{
    Console.WriteLine("Se puede convertir la fecha");
    Console.WriteLine(fecha4.ToString("d"));
    Console.WriteLine(fecha4.ToString("D"));
    Console.WriteLine(fecha4.ToString("g"));
    Console.WriteLine(fecha4.Day);
    Console.WriteLine(fecha4.Month);
    Console.WriteLine(fecha4.Year);

}
else
    //Arrojar el error al catch
    throw new Exception("ERROR al convertir la fecha \n");

//Tipo de dato TimeSpan --> franjas de tiempo
