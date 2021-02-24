using System;

namespace SalaoT2.Dominio
{
    public class ServicoSolicitado
    {
        public int Id { get; set; }
        public Servico Servico { get; set; }
        public Funcionario Funcionario { get; set; }
        public StatusServico Status { get; set; }
        public DateTime DtServico { get; set; }
        public string AtendimentoFinalizado { get; set; }
        public decimal ServicoPreco { get; set; }
        public string ServicoSolicitadoServicoPreco { get; set; }
        public string StatusAgenda { get; set; }


        public enum StatusServico
        {
            ARealizar,
            Realizado,
            Reagendado,
            CanceladoPeloCliente,
            CanceladoPeloSalao
        }

        public void IncluirServicoSolicitado(int id, Servico servico, Funcionario func, decimal servicopreco, string servicoSolicitadoServicoPreco, string statusAgenda, string atendimentoFinalizado)
        {
            Id = id;
            Servico = servico;
            Funcionario = func;
            ServicoPreco = servicopreco;
            ServicoSolicitadoServicoPreco = servicoSolicitadoServicoPreco;
            StatusAgenda = statusAgenda;
            AtendimentoFinalizado = atendimentoFinalizado;
        }
    }
}
