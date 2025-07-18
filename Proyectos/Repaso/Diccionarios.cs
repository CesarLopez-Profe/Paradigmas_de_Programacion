//Declaración de un diccionario en C#:
//primer dato clave y segundo dato valor
var dic_capitales = new Dictionary<int, string>();


dic_capitales.Add(1, "París");
dic_capitales.Add(2, "Londres");
dic_capitales.Add(3, "Madrid");

dic_capitales[4] = "Buenos Aires";


foreach (var kvp in dic_capitales)
{
    Console.WriteLine($"Clave: {kvp.Key}, Valor: {kvp.Value}");
}

if (dic_capitales.ContainsKey(3))
    Console.WriteLine("La clave 3 existe");

if (dic_capitales.ContainsValue("Bogotá"))
    Console.WriteLine($"El valor Bogotá existe");

dic_capitales.Remove(3);

dic_capitales[3] = "Estocolmo";

 var dic_long_pistas_aerop_col = new Dictionary<string, float>{

     {"EOH", 2.5f },
     {"JMC",3.2f },
     {"BOG",4.2f }
 };

 //Linq soobre diccionario

 float long_min_A350 = 3.1f;
 var puede_aterrizar = dic_long_pistas_aerop_col.Where(aer => aer.Value >= long_min_A350);
 foreach (var item in puede_aterrizar)
 {
     Console.WriteLine($"El Airbus A350 puede aterrizar en {item.Key}");
 }