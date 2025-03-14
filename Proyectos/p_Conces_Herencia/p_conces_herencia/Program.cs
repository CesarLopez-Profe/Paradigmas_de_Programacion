// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using p_conces_herencia.Clases;

Concesionario auto_orcasita = new Concesionario("Auto Orcasita", "Calle 1 # 2-3");
Persona arroyave = new Vendedor("Arroyave Cardona", "4555454544", 0.019f);
Persona ardila = new Cliente("Ardila Restrepo", "45454554446", 0.024f);
List<Persona> l_personas = new List<Persona>();
l_personas.Add(arroyave);
l_personas.Add(ardila);

Taxi tax = new Taxi("AAA234", "Toyota", "Corolla", 2025, 1600, 5, 
Automovil.l_nro_puertas.p5, "TO12345", "Tax Tabares");

Console.WriteLine(auto_orcasita.VenderAutomovil(tax, l_personas, 70000000));
/*Console.WriteLine(veh1.GetType().Name);
Console.WriteLine(veh1 is Automovil);
Console.WriteLine(veh1 is Taxi);*/



