namespace EstacionaAi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int precoInicial = 0;
            int precoPorHora = 0;
         Estacionamento estacionaAi = new Estacionamento(precoInicial, precoPorHora);

            bool exibirMenu = true;
            
            while (exibirMenu)
            {
                Console.WriteLine("Bem-vindo(a) ao estacionamento EstacionaAi\nDigite abaixo a opção que deseja prosseguir: ");
                Console.WriteLine("1 - Cadastar placa de veículo; ");
                Console.WriteLine("2 - Remover veículo; ");
                Console.WriteLine("3 - Ver seus cadastros; ");
                Console.WriteLine("4 - Sair do programa.");

                switch(Console.ReadLine())
                {
                    case "1":
                        estacionaAi.AdicionarAutomovel();                       
                        break;
                    case "2":
                        estacionaAi.RemoverAutomovel();  
                        break; 
                    case "3":
                        estacionaAi.ListaVeiculos();
                        break;
                    case "4":
                        exibirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Comando inválido: ");
                        break;
                }

                Console.WriteLine("Aperte qualquer tecla para continuar: ");
                Console.ReadLine();
                Console.Clear();
            }

            if(exibirMenu == false)
            {
                Console.WriteLine("Fim do programa! ");
            }
            
        }
    }
}