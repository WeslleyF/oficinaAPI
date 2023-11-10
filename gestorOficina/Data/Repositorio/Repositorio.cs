using gestorOficina.Data.Context;
using gestorOficina.Modelo.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;
using System.Reflection;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace gestorOficina.Data.Repositorio
{
    public class Repositorio<Entidade> : IRepositorio<Entidade> where Entidade : IEntidade
    {
        private readonly OficinaContext _oficinaContext;
        public Repositorio(OficinaContext oficinaContext)
        {
            _oficinaContext = oficinaContext;
        }
        
        public async Task<Entidade> Adicionar(Entidade instancia)
        {
            await _oficinaContext.AddAsync(instancia);
            _oficinaContext.SaveChanges();
            return instancia;
        }

        public Entidade Atualizar(Entidade instancia)
        {
            _oficinaContext.Update(instancia);
            _oficinaContext.SaveChanges();
            return instancia;
        }

        public virtual Task<List<Entidade>> Recuperar(Func<Entidade, bool>? where)
        {
            return null;
        }

        public Entidade Remover(Entidade instancia)
        {
            _oficinaContext.Remove(instancia);
            _oficinaContext.SaveChanges();
            return instancia;
        }

    }
}
