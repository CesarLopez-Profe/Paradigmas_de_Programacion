using Bib_multas.Clases;

namespace AppMultas.web.Servicios
{
    public class TransitoService
    {
        private readonly Transito _transito;
        public Transito Instancia => _transito;

        public TransitoService()
        {
            _transito = new Transito("Calle 100 #45-50", 3100000000);
        }

        public ulong[] Totalizar()
        {
            return _transito.Totalizar_multas();
        }

        
    }
}
