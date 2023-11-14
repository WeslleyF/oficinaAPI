using Microsoft.EntityFrameworkCore;
using OficinaAPI.Dados.Context;
using OficinaAPI.Modelo.Classes;

namespace OficinaAPI.Dados.Classes
{
    public class RepositorioCidade : Repositorio<Cidade>
    {
        private readonly OficinaContext _context;
        public RepositorioCidade(OficinaContext oficinaContext) : base(oficinaContext)
        {
            _context = oficinaContext;
        }

        public override Task<List<Cidade>> Recuperar(Func<Cidade, bool>? where)
        {
            return _context.Set<Cidade>().ToListAsync();
        }


    }
}
