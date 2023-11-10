using gestorOficina.Data.Context;
using gestorOficina.Modelo.Classes;
using Microsoft.EntityFrameworkCore;

namespace gestorOficina.Data.Repositorio
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
