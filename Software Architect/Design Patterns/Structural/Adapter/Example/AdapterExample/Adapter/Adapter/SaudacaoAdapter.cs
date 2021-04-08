using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class SaudacaoAdapter : ISaudacao
    {
        private readonly ISaudacaoMelhorada _saudacaoMelhorada;
        public SaudacaoAdapter(ISaudacaoMelhorada saudacaoMelhorada)
        {
            _saudacaoMelhorada = saudacaoMelhorada;
        }

        public void boaNoite()
        {
            _saudacaoMelhorada.boaNoite();
        }

        public void boaTarde()
        {
            _saudacaoMelhorada.boaTarde();
        }

        public void bomDia()
        {
            _saudacaoMelhorada.bomDia();
        }
    }
}
