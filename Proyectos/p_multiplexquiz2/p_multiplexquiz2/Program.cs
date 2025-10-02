// See https://aka.ms/new-console-template for more information
using p_multiplexquiz2.Clases;

Console.WriteLine("Hello, World!");

Agua brisa_200 = new Agua("Agua Brisa 200", 10500, 200);
Agua brisa_600 = new Agua("Agua Brisa 600", 14000, 600);
Gaseosa gas_grande = new Gaseosa("Gaseosa Tamaño Grande", 19000, Gaseosa.enum_tamano.Grande);
Crispeta cris_salada = new Crispeta("Cubeta crispeta salada", 25000, Crispeta.enum_sabor.Saladas);

List<Producto> l_prod_conf = new List<Producto>();

l_prod_conf.Add(brisa_600);
l_prod_conf.Add(brisa_200);
l_prod_conf.Add(gas_grande);
l_prod_conf.Add(cris_salada);

Dulceria dulc_unicentro = new Dulceria (l_prod_conf);

List<Producto> l_prod_vend = new List<Producto>();

l_prod_vend.Add(brisa_600);
l_prod_vend.Add(brisa_600);
l_prod_vend.Add(brisa_200);
l_prod_vend.Add(cris_salada);

Console.WriteLine(dulc_unicentro.VenderProducto(l_prod_vend));


Sala sala1 = new Sala(1, 20, 50);
Sala cinebar = new Sala(2, 50, 10);

Pelicula ToyStory4 = new Pelicula("Toy Story IV", "Toy Story IV", new TimeSpan(2, 0, 0), 6);
Pelicula _4Fantasticos = new Pelicula("Fantastic Four", "Los Cuatro Fantásticos", new TimeSpan(1, 35, 0), 12);

Funcion fun1 = new Funcion(sala1,_4Fantasticos, new DateTime(2025,10,6,14,0,0));
Funcion fun2 = new Funcion(sala1, _4Fantasticos, fun1.Hora_final);
Funcion fun3 = new Funcion(sala1, _4Fantasticos, fun2.Hora_final);
Funcion fun4 = new Funcion(sala1, _4Fantasticos, fun3.Hora_final);

Multiplex unicentro = new Multiplex("Cine Colombia Unicentro", l_prod_conf);

Taquilla taq1 = new Taquilla(1, new Taquillero("Juan Perez", 64455642, 3125852146));

unicentro.L_taquillas.Add(taq1);






Console.ReadKey();





