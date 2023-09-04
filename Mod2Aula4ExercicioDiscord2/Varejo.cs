using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Aula5ExercicioDiscord1
{
    internal class Varejo : Empresa, IEmpresa
    {
        private readonly bool EnviarNotificacaoWhatsApp;

        public Varejo( bool enviarNotificacaoWhatsapp)
        {
            EnviarNotificacaoWhatsApp = enviarNotificacaoWhatsapp;
        }

        public void EnviarMensagemCliente()
        {
            Console.WriteLine($"Notificação enviada {EnviarNotificacaoWhatsApp}");
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Varejo vende produtos");

            if (EnviarNotificacaoWhatsApp)
            {
                IEnviarNotificacao notificacao = new EnviarNotificacaoWhatsapp();
                notificacao.EnviarMensagemCliente();
            }
            
        }
        
    }
}
