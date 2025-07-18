    //tuplas clásicas --> Tuple<T> dos ítems
    var tupla = Tuple.Create("Juan", 39);
    Console.WriteLine($"Nombre: {tupla.Item1}, Edad: {tupla.Item2}");



    //tuplas modernas --> ValueTuple (moderno)
    var persona = ("Ana", 25, 5000.50m);
    Console.WriteLine($"Nombre: {persona.Item1}, Edad: {persona.Item2}, Saldo: {persona.Item3}");

    //tuplas con nombres
    var ciudades = (Ciudad: "Medellin", Departamento: "Antioquia", Habitantes: 4500000);
    Console.WriteLine($"Ciudad: {ciudades.Ciudad}, Departamento: {ciudades.Departamento}, Población: {ciudades.Habitantes.ToString("")}");

/*devolver tupla en método
 *
 */
(string Nombre, int Edad) ObtenerPersona()
    {
        return ("Elena", 30);
    }

 

// Lista de tuplas
 var personas = new List<(string Nombre, int Edad, decimal Saldo)>
{
    ("Juan", 39, 5000000),
    ("Pedro", 86, 800000),
    ("Ana", 18, 700000),
    ("Elena", 16, 4890000)
};

foreach (var p in personas)
{
    Console.WriteLine($"Nombre: {p.Nombre}, Edad: {p.Edad}, Saldo: {p.Saldo:C}");
}


//Linq

    var personas_l = new List<(string Nombre, int Edad, decimal Saldo)>
    {
    ("Juan", 39, 5000000),
    ("Pedro", 86, 800000),
    ("Ana", 18, 700000),
    ("Elena", 16, 4890000)
    };

    var mayoresEdad = personas_l
        .Where(p => p.Edad >= 18)
        .ToList();

    mayoresEdad.ForEach(p =>
        Console.WriteLine($"Nombre: {p.Nombre}, Edad: {p.Edad}, Saldo: {p.Saldo:C}")
    );

    var nombresYSaldo = personas_l
        .Select(p => (p.Nombre, p.Saldo))
        .ToList();

    nombresYSaldo.ForEach(p =>
        Console.WriteLine($"Nombre: {p.Nombre}, Saldo: {p.Saldo:C}")
    );

    var ordenadosPorSaldo = personas_l
        .OrderByDescending(p => p.Saldo)
        .ToList();

    ordenadosPorSaldo.ForEach(p =>
        Console.WriteLine($"{p.Nombre} - {p.Saldo:C}")
    );