// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using asp_operacionesBD.Interfaces;
using Castle.DynamicProxy;
using asp_operacionesBD.Clases;
using asp_operacionesBD.Aspectos;

try
{
    var proxy_gen = new ProxyGenerator();

    //Creación del proxy dinámico para usar los aspectos
    IOperacionesBD proxy_bd_micros = proxy_gen.CreateInterfaceProxyWithTarget(
        typeof(IOperacionesBD ), 
        new OperaBDMicrosoft(),
        new InterceptorOperBD()) as IOperacionesBD;

    IOperacionesBD proxy_bd_postgres = proxy_gen.CreateInterfaceProxyWithTarget(
    typeof(IOperacionesBD),
    new OperaBDPostgres(),
    new InterceptorOperBD()) as IOperacionesBD;



    //Usar el proxy
    proxy_bd_micros.Crear();
    proxy_bd_postgres.Eliminar();

    Console.ReadLine();
}
catch (Exception err)
{
    Console.WriteLine(err.ToString());
}