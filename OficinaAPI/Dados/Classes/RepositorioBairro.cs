using Microsoft.EntityFrameworkCore;
using OficinaAPI.Dados.Context;
using OficinaAPI.Modelo.Classes;

namespace OficinaAPI.Dados.Classes
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
