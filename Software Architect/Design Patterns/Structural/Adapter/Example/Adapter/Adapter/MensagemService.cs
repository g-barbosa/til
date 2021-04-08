using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class MensagemService
    {
        private readonly ISaudacao _saudacao;

        public MensagemService(ISaudacao saudacao)
        {
            _saudacao = saudacao;
        }

        public void EnviarBomDia()
        {
            _saudacao.bomDia();
        }
        public void EnviarBoaTarde()
        {
            _saudacao.boaTarde();
        }
        public void EnviarBoaNoite()
        {
            _saudacao.boaNoite();
        }
    }
}
