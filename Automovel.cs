using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionaAi
{
    internal class Automovel 
    {
        private string modelo, cor, placa;
        private int ano;
        Condutor condutor;
        public Automovel(string modelo, string cor, string placa, int ano, Condutor condutor)
        {
            this.modelo = modelo;
            this.cor = cor; 
            this.placa = placa;
            this.ano = ano;
            this.condutor = condutor;
        }

        public Automovel()
        {

        }

        public void setModelo(string newModelo)
        {
            this.modelo = newModelo;
        }
        public string getModelo()
        {
            return this.modelo;
        }

        public void setCor(string newCor)
        {
            this.cor = newCor;
        }
        public string getCor()
        {
            return this.cor;
        }
        
        public void setPlaca(string newPlaca)
        {
            this.placa = newPlaca;
        }
        public string getPlaca()
        {
            return this.placa;
        }

        public void setAno(int newAno)
        {
            this.ano = newAno;
        }
        public int getAno()
        {
            return this.ano;
        }
    }
}
