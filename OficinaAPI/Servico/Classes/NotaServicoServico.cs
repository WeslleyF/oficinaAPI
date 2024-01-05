using OficinaAPI.Dados.Interface;
using OficinaAPI.Dados.Classes;
using OficinaAPI.Modelo.Classes;
using OficinaAPI.Modelo.Interface;
using OficinaAPI.Servico.Interfaces;

namespace OficinaAPI.Servico.Classes
{
    public class NotaServicoServico : Servico<NotaServico>, INotaServicoServico
    {
        private readonly INotaServicoRepositorio _repositorioNotaServico;
        private readonly IServico<Cliente> _servicoCliente;
        private readonly IServico<OficinaAPI.Modelo.Classes.Servico> _servicoServico;
        public NotaServicoServico(INotaServicoRepositorio repositorio, IServico<Cliente> servicoCliente, 
                                 IServico<OficinaAPI.Modelo.Classes.Servico> servicoServico) : base(repositorio)
        {
          _servicoCliente         = servicoCliente;   
          _repositorioNotaServico = repositorio; 
          _servicoServico         = servicoServico;
        }

        public async Task<NotaServico> Emitir(NotaServico notaServico)
        {
           if(notaServico.itens is null || notaServico.itens.Count == 0)
             throw new Exception("Não informado nenhum item.");
           

           Cliente? cliente        = await _servicoCliente.Recuperar(notaServico.codCliente);
           if(cliente is null)
             throw new Exception("Cliente não informado.");

           NotaServico documento   = new NotaServico();
           documento.dataCadastro  = DateTime.UtcNow;
           documento.dataPrestacao = notaServico.dataPrestacao;
           documento.valor         = notaServico.valor;
           documento.codCliente    = notaServico.codCliente;
           documento.cliente       = await _servicoCliente.Recuperar(notaServico.codCliente);
           documento.itens         = new List<NotaServicoItem>();

           await _repositorioNotaServico.Adicionar(documento);
           
           OficinaAPI.Modelo.Classes.Servico? servico;
           NotaServicoItem notaServicoItem;
           notaServico.itens?.ForEach(async (nsi) => {
             servico = await _servicoServico.Recuperar(nsi.codServico);
             if(servico is null) 
               throw new Exception("Serviço não informado.");
             
             notaServicoItem                = new NotaServicoItem();
             notaServicoItem.codNotaServico = documento.codNotaServico;
             notaServicoItem.notaServico    = documento;
             notaServicoItem.codServico     = servico.codServico;
             notaServicoItem.servico        = servico;
             notaServicoItem.valor          = servico.valor;
             notaServicoItem.qtd            = nsi.qtd;
             notaServicoItem.valorTotal     = nsi.qtd * servico.valor;

             await _repositorioNotaServico.adicionarItem(notaServicoItem);
             documento.itens.Add(notaServicoItem);
           });

           return documento;
        }

        public async Task<List<NotaServico>> RecuperarComCliente()
        {
          return await _repositorioNotaServico.RecuperarComCliente();
        }

        public async Task<List<NotaServicoItem>> recuperarItens(int codNotaServico)
        {
          return await _repositorioNotaServico.recuperarItens(codNotaServico);
        }
    }
}
