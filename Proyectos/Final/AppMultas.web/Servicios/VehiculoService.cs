using Bib_multas.Clases;

namespace AppMultas.web.Servicios
{
    public class VehiculoService
    {
        private readonly List<Vehiculo> _vehiculos = new();

        public void Agregar(Vehiculo vehiculo)
        {
            _vehiculos.Add(vehiculo);
        }

        public IEnumerable<Vehiculo> ObtenerTodos()
        {
            return _vehiculos;
        }

        public Vehiculo? BuscarPorPlaca(string placa)
        {
            return _vehiculos.FirstOrDefault(v => v.Placa == placa);
        }

        public bool Existe(string placa)
        {
            return _vehiculos.Any(v => v.Placa == placa);
        }
    }
}
