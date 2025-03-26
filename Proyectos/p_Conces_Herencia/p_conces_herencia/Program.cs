// See https://aka.ms/new-console-template for more information
using p_conces_herencia.Clases;
//Console.WriteLine("Hello, World!");

try
{
    Concesionario auto_pibe = new Concesionario("Compraventa el pibe", "Calle 100 48-21");
    Taxi tax1 = new Taxi("AAA123", "Toyota", "Corolla", 2025, 1600, 5, Automovil.l_nro_puertas.p5,
        "TO001", "Tax Copebombas");

    Automovil tax2 = new Taxi("AAA234", "Toyota", "Corolla", 2025, 1600, 5, Automovil.l_nro_puertas.p5,
        "TO002", "Tax Copebombas");

    Persona juan = new Vendedor("Juan Perez Gomez", "1205000000", 0.016f);
    Persona susana = new Cliente("Susana Gallego", "1205000000", 0.021f);
    Persona mateo = new Cliente("Mateo de jesus Gallego", "1205000000", 0.021f);

    List<Persona> l_personas_ppal = new List<Persona>();
    l_personas_ppal.Add(mateo);
    l_personas_ppal.Add(susana);

    Console.WriteLine(auto_pibe.VenderAuto(new Venta(l_personas_ppal, tax1, 100000000)));


}
catch (Exception err)
{
    Console.WriteLine (err.ToString ());
}



