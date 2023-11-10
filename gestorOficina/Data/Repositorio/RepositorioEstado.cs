using gestorOficina.Data.Context;
using gestorOficina.Modelo.Classes;
using Microsoft.EntityFrameworkCore;

namespace gestorOficina.Data.Repositorio
{
    public class RepositorioEstado : Repositorio<Estado>
    {
        private readonly OficinaContext _context;
        public RepositorioEstado(OficinaContext oficinaContext) : base(oficinaContext)
        {
            _context = oficinaContext;
        }

        public override Task<List<Estado>> Recuperar(Func<Estado, bool>? where)
        {
           return _context.Set<Estado>().ToListAsync();
        }


    }
}
