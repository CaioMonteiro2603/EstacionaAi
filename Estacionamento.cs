using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionaAi
{
    internal class Estacionamento
    {
        private int precoInicial, precoPorHora;
        private List<Automovel> _PlacaAutomovel = new List<Automovel>();

        public Estacionamento(int precoInicial, int precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarAutomovel()
        {
            Console.WriteLine("Digite o modelo do carro: ");
            string modeloCarro = Console.ReadLine();
            Console.WriteLine("Digite a cor do carro: ");
            string corCarro = Console.ReadLine();
            Console.WriteLine("Digite a placa do carro: ");
            string placaCarro = Console.ReadLine();
            Console.WriteLine("Digite o ano do carro: ");
            int anoCarro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome e sobrenome do condutor: ");
            string nomeCondutor = Console.ReadLine();
            Console.WriteLine("Digite o CPF do condutor: ");
            string cpfCondutor = Console.ReadLine();
            Automovel automovel1 = new Automovel(modeloCarro, corCarro, placaCarro, anoCarro, new Condutor(nomeCondutor, cpfCondutor));
            Console.WriteLine("Placa adicionada com sucesso! ");
            _PlacaAutomovel.Add(automovel1);
        }

        public void RemoverAutomovel()
        {
            Automovel placaAutomovel = new Automovel();

            precoInicial = 5;
            precoPorHora = 10; 

            Console.WriteLine("Digite a placa do veículo que deseja remover: ");
            string placaRemocao = Console.ReadLine(); 

           for(int i = 0; i < _PlacaAutomovel.Count; i++)
            {
                if(_PlacaAutomovel.ElementAt(i).getPlaca().ToUpper() == placaRemocao.ToUpper())
                {
                    placaAutomovel = _PlacaAutomovel[i];
                    _PlacaAutomovel.Remove(placaAutomovel);
                    Console.WriteLine("Digite a quantidade de horas estacionadas: ");
                    int horasEstacionadas = Convert.ToInt32(Console.ReadLine()); 
                    double valorTotal = precoInicial + (precoPorHora * horasEstacionadas);
                    Console.WriteLine($"O veiculo da placa {placaAutomovel.getPlaca()} foi removido. O valor foi de {valorTotal} reais!");

                } else
                {
                    Console.WriteLine("O veículo da placa digitada não existe em nosso banco de dados!\nTente novamente! ");
                    break; 
                }
            }
        }
        public void ListaVeiculos()
        {
            foreach (var placa in _PlacaAutomovel)
            {
                Console.WriteLine(placa.getPlaca());
            }   
        }
    }
}
