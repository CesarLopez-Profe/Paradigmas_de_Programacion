//Ejemplo linq con listas tuplas

List<(int ID, string Nombre, string Cargo, string Departamento, decimal Salario)> empleados =
            new List<(int, string, string, string, decimal)>();


empleados.Add((1, "Ana Pérez", "Analista", "Finanzas", 4500m));
empleados.Add((2, "Luis Gómez", "Gerente", "TI", 7500m));
empleados.Add((3, "María Torres", "Soporte", "Ventas", 3200m));
empleados.Add((4, "Carlos Ruiz", "Desarrollador", "TI", 6000m));
empleados.Add((5, "Sofía Díaz", "Analista", "Recursos Humanos", 4100m));
empleados.Add((6, "Pedro Herrera", "Gerente", "Finanzas", 8200m));
empleados.Add((7, "Laura Ramírez", "Soporte", "TI", 3300m));
empleados.Add((8, "Diego Mendoza", "Desarrollador", "Ventas", 5400m));
empleados.Add((9, "Valentina López", "Analista", "Finanzas", 3900m));
empleados.Add((10, "Jorge Martínez", "Soporte", "TI", 2800m));
empleados.Add((11, "Camila Rojas", "Gerente", "Ventas", 7800m));
empleados.Add((12, "Andrés Castro", "Desarrollador", "TI", 6200m));
empleados.Add((13, "Paula Vargas", "Analista", "Recursos Humanos", 4000m));
empleados.Add((14, "Esteban Silva", "Soporte", "Finanzas", 3500m));
empleados.Add((15, "Daniela Moreno", "Gerente", "TI", 8000m));

//Ordena por salario
var empleadosOrdenados = empleados.OrderByDescending(e => e.Salario);

//Filtra los de un departamento con unsalario específico
var empleadosTI = empleados.Where(e => e.Departamento == "TI" && e.Salario > 5000);

//Selecciona los nombres de los empleados con salario menor a 4000
var nombres = empleados.Where(e => e.Salario < 4000)
                       .Select(e => e.Nombre);

//Cuenta cuántos empleados son gerentes
var cantidadGerentes = empleados.Count(e => e.Cargo == "Gerente");

//Encuentra el promedio de los empleados de finanzas
var promedioFinanzas = empleados.Where(e => e.Departamento == "Finanzas")
                                .Average(e => e.Salario);


//************************

//Ejemplo linq con diccionario
Dictionary<int, (string Nombre, string Cargo, string Departamento, decimal Salario)> empleadosDict =
    empleados.ToDictionary(e => e.ID, e => (e.Nombre, e.Cargo, e.Departamento, e.Salario));

//Filtra los de un departamento con un salario específico
var empleadosTI = empleadosDict.Values.Where(e => e.Departamento == "TI" && e.Salario > 5000);

//Selecciona los nombres de los empleados con salario menor a 4000
var nombres = empleadosDict.Values.Where(e => e.Salario < 4000)
                                   .Select(e => e.Nombre);

//Cuenta cuántos empleados son gerentes
var cantidadGerentes = empleadosDict.Values.Count(e => e.Cargo == "Gerente");

//Encuentra el promedio de los empleados de finanzas
var promedioFinanzas = empleadosDict.Values.Where(e => e.Departamento == "Finanzas")
                                           .Average(e => e.Salario);



