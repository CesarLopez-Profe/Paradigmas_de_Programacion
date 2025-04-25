using AppMultas.web.Servicios;

var builder = WebApplication.CreateBuilder(args); //varaible para instanciar la app web

// Add services to the container.
builder.Services.AddControllersWithViews();

//se registran los servicios como singleton=>patrón arquitéctonico 

builder.Services.AddSingleton<ConductorService>();
builder.Services.AddSingleton<VehiculoService>();
builder.Services.AddSingleton<MultaService>();

var app = builder.Build(); //Build() instancia esta app web y la asigna a app

//Datos precargados
var conductorService = app.Services.GetRequiredService<ConductorService>();

conductorService.Agregar(new Bib_multas.Clases.Conductor(
    Bib_multas.Clases.Conductor.tipos_id.CC, "123", "Carlos Pérez", 30));

conductorService.Agregar(new Bib_multas.Clases.Conductor(
    Bib_multas.Clases.Conductor.tipos_id.CE, "456", "Ana Gómez", 28));

var vehiculoService = app.Services.GetRequiredService<VehiculoService>();
vehiculoService.Agregar(new Bib_multas.Clases.Vehiculo(
    "ABC123", "Toyota", "Corolla", new DateTime(2020, 1, 1)));

vehiculoService.Agregar(new Bib_multas.Clases.Vehiculo(
    "XYZ789", "Mazda", "CX-5", new DateTime(2019, 6, 15)));

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts(); //HSTS (HTTP Strict Transport Security), Obliga a usar navegación segura
}

//app.UseHttpsRedirection();
app.UseStaticFiles(); //sirve para usar archivos estáticos (como HTML, CSS, JS, imágenes) desde la carpeta wwwroot

app.UseRouting();  //Habilita el enrutamiento, es decir, la capacidad de ASP.NET Core para asociar URLs con controladores y acciones.

app.UseAuthorization(); //verifica si el usuario tiene permisos para acceder a ciertos recursos.

app.MapControllerRoute( //Se configura la ruta por defecto para MVC
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); //Levanta la App en el navegador
