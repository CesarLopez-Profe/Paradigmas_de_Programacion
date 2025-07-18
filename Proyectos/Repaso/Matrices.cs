//Matrices
//1. Definirla vacía
               
ulong[,] m_premios;

//a la vacía le llevamos dimension
m_premios = new ulong[4, 5];

//2. Deinir la matriz con elementos
char[,] m_triqui = new char[4, 3]
{
    {'X','O','O'},
    {'O','X','X'},
    {'X','X','X'},
    {'O','X','X'},
}; 

//Impresión de la matriz: Se usan dos ciclos
//x filas ; El for más externo son las filas y más interno son las columnas
for(byte i = 0; i <= 3; i++)
{
    for (byte j = 0; j <= 2; j++)
    {
        Console.Write(m_triqui[i,j]);
    }
    Console.WriteLine();
}