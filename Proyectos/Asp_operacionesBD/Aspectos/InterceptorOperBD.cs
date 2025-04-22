using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace asp_operacionesBD.Aspectos
{
    public class InterceptorOperBD:IInterceptor
    {

        void IInterceptor.Intercept(IInvocation llamado)
        {
            //Escribo quien llama al proxy
            Console.WriteLine($"El método que está llamando es: {llamado.Method.Name}");

            //se ejecuta el método que se está llamando por medio de proceed
            llamado.Proceed();

            //Escribo el resultado de la invocación
            Console.WriteLine($"El método {llamado.Method.Name} se ejecutó exitosamente");

        }

    }
}
