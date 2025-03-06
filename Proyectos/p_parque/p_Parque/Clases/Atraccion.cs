using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Parque.Clases
{
    internal class Atraccion
    {
        //Atributos de usuario
        private string nombre;
        private TimeSpan duracion;
        private byte ptos_ingresar;

        //Atributos de validación
        private readonly byte ptos_min = 10, ptos_max = 25, long_min_nom=5;
        private readonly TimeSpan dur_min = new TimeSpan(0,1,0), dur_max = new TimeSpan(0,5,0);

        public Atraccion(string nombre, TimeSpan duracion, byte ptos_ingresar)
        {
            Nombre = nombre;
            Duracion = duracion;
            Ptos_ingresar = ptos_ingresar;
        }

        public string Nombre { get => nombre;
            set => nombre = !(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value) || value.Length < long_min_nom) 
                ? value : throw new Exception($"El nombre {value} no es válido"); }
        public byte Ptos_ingresar { get => ptos_ingresar; 
            set => ptos_ingresar = value >=ptos_min && value <=ptos_max?value:throw new Exception($"Los puntos {value} no son válidos"); }
        public TimeSpan Duracion { get => duracion; 
            set => duracion = value >= dur_min && value <= dur_max?value: throw new Exception($"La duración {value} no es válida válidos");
        }
        
        public string RegistrarIngreso(Manilla manilla)
        {
            try
            {
                if(manilla.Saldo_ptos >= ptos_ingresar)
                {
                    manilla.RestarSaldo(ptos_ingresar);
                    Parque.l_registros.Add(new Registro(manilla, this));
                    return ($"Ingreso aceptado, le quedan de saldo {manilla.Saldo_ptos} puntos");
                }
                else
                    return ($"Ingreso rechazado, su saldo es {manilla.Saldo_ptos} puntos y para ingresar necesita {ptos_ingresar} puntos" );
            }
            catch (Exception ex)
            {
                throw new Exception("ocurrió un error en registrar ingreso \n" + ex.ToString());
            }
        }

    }
}
