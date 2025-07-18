
using System;
using System.IO;

//Acá se muestra el recorrido de un archivo y el cálculo del promedio de las mediciones
//La gestión de archivos debe ir entre bloques try-catch para manejar errores
try
{
    string linea;
    float promedio = 0;
    uint suma = 0, nro = 0;
    byte cuenta = 0;

    StreamReader archivo = new StreamReader(""); //Especificar la ruta del archivo entre comillas

    linea = archivo.ReadLine();
    while (linea != null)
    {

        if (uint.TryParse(linea, out nro))
        {
            cuenta++;
            linea = archivo.ReadLine(); //Instrucción de continuidad del ciclo
        }
        else throw new Exception("Error con los datos del archivo"); //Detiene la ejecución y lanza el error
    }
    StreamReader archivo1 = new StreamReader("C:\\Users\\000096175\\Documents\\mediciones.txt");
    promedio = sumar_mediciones(archivo1) / cuenta;
}
catch (Exception)
{
    throw new Exception("Error calculando la función promedio");
}