using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionaAi
{
    internal class Condutor
    {
        private string nomeCondutor, cpf;

        public Condutor(string nomeCondutor, string cpf)
        {
            this.nomeCondutor = nomeCondutor;
            this.cpf = cpf;
        }

        public void setNomeCondutor(string newNomeCondutor)
        {
            this.nomeCondutor = newNomeCondutor;
        }
        public string getNomeCondutor()
        {
            return this.nomeCondutor;
        }

        public void setCpf(string newCpf)
        {
            this.cpf = newCpf;
        }
        public string getCpf()
        {
            return this.cpf;
        }
    }
}
