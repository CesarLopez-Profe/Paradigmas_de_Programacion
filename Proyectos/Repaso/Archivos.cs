
using System;
using System.IO;

//Acá se muestra el recorrido clásico de un archivo y el cálculo del promedio de las mediciones
//La gestión de archivos debe ir entre bloques try-catch para manejar errores
try
{
    string linea;
    float promedio = 0;
    uint suma = 0, nro = 0;
    byte cuenta = 0;

    StreamReader archivo = new StreamReader(""); //Especificar la ruta del archivo entre comillas

    
    while ((linea = archivo.ReadLine()) != null)
    {

        if (uint.TryParse(linea, out nro))
        {
            cuenta++;
            
        }
        else throw new Exception("Error con los datos del archivo"); //Detiene la ejecución y lanza el error
    }
    archivo.Close();
}
catch (Exception)
{
    throw new Exception("Error calculando la función promedio");
}

//Si lo que se quiere es leer grandes bloques de texto
string rutaArchivo = "datos.txt";
        char[] buffer = new char[1024]; // Leer 1KB a la vez

        try
        {
            using (StreamReader archivo = new StreamReader(rutaArchivo))
            {
                int charsLeidos;
                while ((charsLeidos = archivo.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string bloque = new string(buffer, 0, charsLeidos);
                    Console.Write(bloque); // Procesar el bloque
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el archivo: " + ex.Message);
        }

//Recorrido de un archivo optimizado con LINQ, Lee línea por línea de forma diferida (lazy loading).
//FileReadLines, devuelve un IEnumerable<string> que permite recorrer el archivo sin cargarlo completamente en memoria.
//foreach lee cada línea desde el disco

string rutaArchivo = "datos.txt";

        try
        {
            foreach (string linea in File.ReadLines(rutaArchivo))
            {
                Console.WriteLine(linea);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el archivo: " + ex.Message);
        }

//