using Bib_multas.Clases;

namespace AppMultas.web.Servicios
{
    public class ConductorService
    {
        private readonly List<Conductor> _conductores = new();

        public void Agregar(Conductor conductor)
        {
            _conductores.Add(conductor);
        }

        public IEnumerable<Conductor> ObtenerTodos()
        {
            return _conductores;
        }

        public Conductor? BuscarPorId(string id)
        {
            return _conductores.FirstOrDefault(c => c.Id == id);
        }
    }
}



