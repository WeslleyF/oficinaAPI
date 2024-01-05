using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OficinaAPI.Dados.Context;
using OficinaAPI.Dados.Interface;
using OficinaAPI.Modelo.Classes;
using OficinaAPI.Modelo.Interface;
using System.Collections.Generic;
using System.Reflection;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OficinaAPI.Dados.Classes
{
    public class NotaServicoRepositorio : Repositorio<NotaServico>, INotaServicoRepositorio
    {
        public NotaServicoRepositorio(OficinaContext oficinaContext) : base(oficinaContext)
        {}

        public async Task<NotaServicoItem> adicionarItem(NotaServicoItem item)
        {
          await _oficinaContext.notaServicoItem.AddAsync(item);
          _oficinaContext.SaveChanges();
          return (item);
        }
        public async Task<List<NotaServicoItem>> recuperarItens(int codNotaServico)
        {
          return await _oficinaContext.notaServicoItem.Where(nsi => nsi.codNotaServico == codNotaServico).Include(nsi => nsi.servico).ToListAsync();
        }

        public async Task<List<NotaServico>> RecuperarComCliente()
        {
          return await _oficinaContext.notaServico.Include(ns => ns.cliente).ToListAsync();
        }
    }
}
