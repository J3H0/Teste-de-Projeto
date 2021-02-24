using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaoT2.Dominio
{
    public class Agendamento
    {    
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public ServicoSolicitado ServicoSolicitado { get; set; }
        public DateTime? DtAgendamento { get; set; }
        public DateTime DataChegada { get; set; }
        public string Anotacao { get; set; }
        public StatusAgenda Status { get; set; }
        public decimal ServicoPreco { get; set; }

        
        public enum StatusAgenda
        {
            ARealizar,
            Realizado,
            Reagendado,
            CanceladoPeloCliente,
            NaoCompareceu,
            CanceladoPeloSalao,
            Pendente
        }
        //ServicoSolicitado.ServicoPreco

        public string IncluirAgendamento(int id, Cliente cliente, ServicoSolicitado servicoParaAgendar,
            DateTime dtAgendamento, List<Agendamento> agenda, string anotacao = "")
        {
            if (PermiteAgendar(agenda, servicoParaAgendar, dtAgendamento))
            {
                return "Esse horário não está livre.";
            }
            else
            {
                Id = id;
                Cliente = cliente;
                ServicoSolicitado = servicoParaAgendar;
                DtAgendamento = dtAgendamento;
                Anotacao = anotacao;

                return "Agendamento feito com sucesso.";
            }
        }

        public string AlterarAgendamento(Cliente cliente, ServicoSolicitado servicoParaAgendar,
            DateTime dtAgendamento, List<Agendamento> agenda, string anotacao = "")
        {
            if (PermiteAgendar(agenda, servicoParaAgendar, dtAgendamento))
            {
                return "Esse horário não está livre.";
            }
            else
            {
                servicoParaAgendar.Status = ServicoSolicitado.StatusServico.Reagendado;
                Cliente = cliente;
                ServicoSolicitado = servicoParaAgendar;
                DtAgendamento = dtAgendamento;
                Anotacao = anotacao;

                return "Agendamento feito com sucesso.";
            }
        }

        private bool PermiteAgendar(List<Agendamento> agenda, ServicoSolicitado servicoParaAgendar, DateTime dtAgendamento)
        {
            DateTime dataTerminoParaAgendar = dtAgendamento.AddMinutes(servicoParaAgendar.Servico.MinutosParaExecucao);
            return (agenda.Any(a => a.DtAgendamento >= dtAgendamento &&
                    (a.Status != StatusAgenda.CanceladoPeloSalao || a.Status != StatusAgenda.CanceladoPeloCliente)) &&
                agenda.Any(a => a.DtAgendamento <= dataTerminoParaAgendar &&
                    (a.Status != StatusAgenda.CanceladoPeloSalao || a.Status != StatusAgenda.CanceladoPeloCliente)));
        }

        public void IncluirServicoSolicitado(int id, Servico servico, Funcionario func, decimal servicopreco, string servicoSolicitadoServicoPreco, string statusAgenda, string atendimentoFinalizado)
        {
            ServicoSolicitado ss = new ServicoSolicitado();
            ss.IncluirServicoSolicitado(id, servico, func, servicopreco, servicoSolicitadoServicoPreco, statusAgenda, atendimentoFinalizado);
            
        }

        public void ExcluirServicoSolicitado(int id)
        {
            //ServicosSolicitados.RemoveAll(x => x.Id == id);
        }
        public void IncluirAtendimentoFinalizado(int id, Cliente cliente, ServicoSolicitado servicoParaAgendar,
            DateTime dtAgendamento, List<Agendamento> agenda, string atendimentoFinalizado, string servicoSolicitadoServicoPreco, string statusAgenda, string anotacao = "")
        {
            
            if (atendimentoFinalizado == servicoSolicitadoServicoPreco);
                                                 
                Console.WriteLine( "Parabéns pela comissão.");

           
        }

        
    }
}
