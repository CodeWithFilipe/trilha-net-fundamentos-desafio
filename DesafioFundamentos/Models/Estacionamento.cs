namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa.ToUpper());
            Console.WriteLine($"Veículo com placa {placa.ToUpper()} estacionado com sucesso!");
        
        }

        public void RemoverVeiculo()
        {
Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            string placaParaRemover = placa.ToUpper();

            if (veiculos.Any(x => x.ToUpper() == placaParaRemover))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                int horas = 0;
                decimal valorTotal = 0;

                if (int.TryParse(Console.ReadLine(), out horas))
                {
                    // Realiza o cálculo
                    valorTotal = precoInicial + (precoPorHora * horas);
                    
                    // Remove a placa da lista
                    veiculos.Remove(placaParaRemover);

                    Console.WriteLine($"O veículo {placaParaRemover} foi removido e o preço total foi de: R$ {valorTotal:N2}");
                }
                else
                {
                    Console.WriteLine("Valor de horas inválido. O veículo não foi removido.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Realiza um laço de repetição (foreach) exibindo os veículos estacionados
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
