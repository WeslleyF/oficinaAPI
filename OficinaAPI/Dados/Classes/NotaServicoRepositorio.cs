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
    }
}
