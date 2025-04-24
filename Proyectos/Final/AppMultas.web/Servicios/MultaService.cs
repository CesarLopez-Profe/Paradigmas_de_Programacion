using Bib_multas.Clases;

namespace AppMultas.web.Servicios
{
    public class MultaService
    {
        private readonly List<Multa> _multas = new();

        public void Agregar(Multa multa)
        {
            _multas.Add(multa);
        }

        public IEnumerable<Multa> ObtenerTodas()
        {
            return _multas;
        }

        public IEnumerable<Multa> BuscarPorConductor(string idConductor)
        {
            return _multas.Where(m => m.Sancionado.Id == idConductor);
        }

        public IEnumerable<Multa> BuscarPorPlaca(string placa)
        {
            return _multas.Where(m => m.Vehiculo.Placa == placa);
        }

        public ulong TotalRecaudado()
        {
            return (ulong)_multas.Sum(m => (decimal)m.Valor);
        }

        public Dictionary<string, (int cantidad, ulong total)> ResumenPorConductor()
        {
            return _multas
                .GroupBy(m => m.Sancionado.Id)
                .ToDictionary(
                    g => $"{g.First().Sancionado.Nombre} ({g.Key})",
                    g => (g.Count(), (ulong)g.Sum(m => (decimal)m.Valor))
                );
        }

        public (int mayor, int menor) ContarPorTipo()
        {
            int may = _multas.Count(m => m is Mayor);
            int men = _multas.Count(m => m is Menor);
            return (may, men);
        }
    }
}
