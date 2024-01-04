﻿using OficinaAPI.Modelo.Classes;
using OficinaAPI.Modelo.Interface;

namespace OficinaAPI.Servico.Interfaces
{
    public interface INotaServicoServico: IServico<NotaServico>
    {
        public Task<NotaServico> Emitir(NotaServico notaServico);
    }
}
