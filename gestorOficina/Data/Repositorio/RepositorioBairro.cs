using gestorOficina.Data.Context;
using gestorOficina.Modelo.Classes;
using Microsoft.EntityFrameworkCore;

namespace gestorOficina.Data.Repositorio
{
    public class RepositorioBairro : Repositorio<Bairro>
    {
        private readonly OficinaContext _context;
        public RepositorioBairro(OficinaContext oficinaContext) : base(oficinaContext)
        {
            _context = oficinaContext;
        }

        public override Task<List<Bairro>> Recuperar(Func<Bairro, bool>? where)
        {
           return _context.Set<Bairro>().ToListAsync();
        }


    }
}
