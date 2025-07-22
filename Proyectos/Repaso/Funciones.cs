//Firma de una función: se refiere al tipo que devuelve, el nombre y los parámetros
using System;

static float[] calcular_sumaypromedio(float[,] matriz)
{
    try
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        float suma = 0;
        int totalElementos = filas * columnas;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                suma += matriz[i, j];
            }
        }

        float promedio = suma / totalElementos;
        return new float[] { suma, promedio };
    }
    catch (Exception error)
    {
        throw new Exception("Error calcular suma y promedio\n" + error);
    }
}

    // Sobrecarga: devuelve una tupla con suma y promedio
    static (float suma, float promedio) calcular_sumaypromedio_tupla(float[,] matriz)
    {
        try
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            float suma = 0;
            int totalElementos = filas * columnas;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    suma += matriz[i, j];
                }
            }

            float promedio = suma / totalElementos;
            return (suma, promedio);
        }
        catch (Exception error)
        {
            throw new Exception("Error calcular suma y promedio (tupla)\n" + error);
        }
    }

    static void Main()
    {
        Random rnd = new Random();
        int M = 3; // filas
        int N = 4; // columnas

        float[,] temperaturas = new float[M, N];

        // Llenar la matriz con valores aleatorios entre 15.0 y 40.0
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                temperaturas[i, j] = (float)(rnd.NextDouble() * 25.0 + 15.0); // 15.0°C a 40.0°C
                Console.Write($"{temperaturas[i, j]:F2}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nUsando función original (arreglo):");
        float[] resultado = calcular_sumaypromedio(temperaturas);
        Console.WriteLine($"Suma: {resultado[0]:F2}, Promedio: {resultado[1]:F2}");

        Console.WriteLine("\nUsando sobrecarga (tupla):");
        var resultadoTupla = calcular_sumaypromedio_tupla(temperaturas);
        Console.WriteLine($"Suma: {resultadoTupla.suma:F2}, Promedio: {resultadoTupla.promedio:F2}");
    }
