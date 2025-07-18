//Vectores - Estáticos - 1 dimensión
//1a forma de declarar un vector, es vacío
uint[] v_edades;
v_edades = new uint[20];

//2a forma llenar el vector de elementos
ushort[] v_puntos = new ushort[] {100,120,95,65,99,100};

//recorrer el vector for
for(byte i = 0; i<=v_puntos.Length-1;i++)
{
    Console.WriteLine(v_puntos[i]);
}

//recorrer el vector for, con la propiedad Length
for(int i = v_puntos.Length-1; i>=0; i--)
{
    Console.WriteLine(v_puntos[i]);
}
