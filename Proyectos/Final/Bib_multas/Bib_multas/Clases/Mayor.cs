using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bib_multas.Eventos;
using Bib_multas.Interfaces;

namespace Bib_multas.Clases
{
    public class Mayor : Multa, ITrabajoSocial, IAnulaLicencia
    {
        public enum inf_mayores { soat_vencido, tecnico_mecanica, Manejar_embriagado}; 
        private inf_mayores inf_mayor;
        private readonly byte cant_sal_min = 15;

        internal Publ_Anul_Lic pub_anu_lic;

        public Mayor(Conductor sancionado, Vehiculo vehiculo, inf_mayores inf_mayor) : base(sancionado, vehiculo)
        {
            this.inf_mayor = inf_mayor;
            Valor = Calcular_sancion();
        }

        internal void EventHandler() { }

        public inf_mayores Inf_mayor { get => inf_mayor; }

        public string Asignar_trabajo_social()
        {
            try
            {
                Random r = new Random();           
                switch(r.Next(1, 4))
                {
                    case 1:                        
                        return "Trabajo social en Biblioteca (2h)";
                    case 2:                       
                        return "Trabajo social en Parques (2h)";
                    case 3:                     
                        return "Trabajo social en Ciclovía (2h)";
                    default:
                        return "La opcion no es valida";
                }            
            }
            catch(Exception e)
            {
                throw new Exception("Error en el metodo Asignar_trabajo_social de la clase Mayor " + e);
            }
        }

        public override ulong Calcular_sancion()
        {
            try
            {
                return (Transito.val_sal_minimo * cant_sal_min);
            }
            catch(Exception e)
            {
                throw new Exception("Ocurrió un error en el metodo Calcular Sancion en la clase Mayor " + e);
            }
        }

        public string Anular_licencia()
        {
            try
            {
                if (Sancionado.Estado_licencia == Conductor.estados_licencia.Activa)
                {
                    Sancionado.Estado_licencia = Conductor.estados_licencia.Suspendida;

                    pub_anu_lic = new Publ_Anul_Lic();
                    pub_anu_lic.evt_anul_lic += EventHandler;
                    return pub_anu_lic.Informar_Anula_Lic(Sancionado);

                }
                else
                    return "El conductor iba con la licencia suspendida";
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error en el metodo Calcular Sancion en la clase Mayor " + e);
            }
        }

        public override string ToString()
        {
            return inf_mayor + " " + Valor;
        }
    }
}
