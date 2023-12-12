using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OficinaAPI.Dados.Context;
using OficinaAPI.Dados.Interface;
using OficinaAPI.Modelo.Interface;
using System.Collections.Generic;
using System.Reflection;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OficinaAPI.Dados.Classes
{
    public class Repositorio<Entidade> : IRepositorio<Entidade> where Entidade : class, IEntidade
    {
        private readonly OficinaContext _oficinaContext;
        private readonly DbSet<Entidade> db;
        public Repositorio(OficinaContext oficinaContext)
        {
            _oficinaContext = oficinaContext;
            db = oficinaContext.Set<Entidade>();
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

        public List<Entidade> Recuperar(Func<Entidade, bool>? where)
        {
            if (where is null) return db.ToList();
            return db.Where<Entidade>(where).ToList();
        }

        public async Task<Entidade?> Recuperar(params object?[]? keyValues)
        {
            return await db.FindAsync(keyValues);
        }

        public Entidade Remover(Entidade instancia)
        {
            _oficinaContext.Remove(instancia);
            _oficinaContext.SaveChanges();
            return instancia;
        }

    }
}
