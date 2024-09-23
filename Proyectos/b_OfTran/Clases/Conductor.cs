using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_OfTran.Clases
{
    internal class Conductor
    {
        public enum l_tipos_id { CC, TI, PAS, CE };
        public enum l_estados_li { Activa, Suspendida };
        
        private l_tipos_id tipo_id;
        private string nro_id;
        private string nombre_completo;
        private byte edad;
        private ulong nro_lic;
        private l_estados_li estado_lic;
        private uint total_ptos;

        internal l_tipos_id Tipo_id { get => tipo_id;  }
        public string Nro_id { get => nro_id; set => nro_id = value; }
        public string Nombre_completo { get => nombre_completo; set => nombre_completo = value; }
        public byte Edad { get => edad; set => edad = value; }
        public ulong Nro_lic { get => nro_lic;  }
        internal l_estados_li Estado_lic { get => estado_lic; set => estado_lic = value; }
        public uint Total_ptos { get => total_ptos; set => total_ptos = value; }

        public Conductor(l_tipos_id tipo_id, string nro_id, string nombre_completo, byte edad)
        {
            this.tipo_id = tipo_id;
            this.Nro_id = nro_id;
            this.Nombre_completo = nombre_completo;
            this.Edad = edad;
            nro_lic = (ulong)new Random().Next(1000000, 10000000);
            total_ptos = 50000;
            estado_lic = l_estados_li.Activa;
        }
    }
}
