namespace iSellAlpha2
{
    internal class Program
    {
        static int LerQuantidade(string mensagem) // Método para ler a quantidade de produtos 
                                                  // static int LerQuantidade(string mensagem): Método que recebe uma mensagem e retorna um número inteiro (int).  
        {
           int quantidade;
            while (true) // Um loop infinito até o usuário digitar corretamente
            {
                Console.Write(mensagem + " ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out quantidade) && quantidade >= 0) // Tenta converter a entrada em número. E retorna se o valor for igual ou maior que 0
                {
                    return quantidade;
                } 
                else //Se for inválida (letra, número negativo, vazio), mostra mensagem de erro e repete.
                {
                    Console.WriteLine("Digite apenas números inteiros.");
                }
            }
        }
        static void Main(string[] args) // Main(): O método principal do programa (onde tudo começa)
        {
            double blusa = 59.90, calca = 99.90, camiseta = 59.90, shortRoupa = 40; // Preço de cada produto
            double valorTotal = 0; // Vair armazenar o valor final do produto

            Console.WriteLine("Bem-vindo à loja iSell!"); // Mostra um título para o usuário

           
           
            int qtdBlusa = LerQuantidade("\nQuantas Blusas você quer comprar?"); //chama o método LerQuantidade() para cada produto
            int qtdCalca = LerQuantidade("Quantas Calças você quer comprar?"); //Cada resposta é salva em uma variável como qtdBlusa
            int qtdCamiseta = LerQuantidade("Quantas Camisetas você quer comprar?");
            int qtdShort = LerQuantidade("Quantos Shorts você quer comprar?");


            //Multiplica a quantidade pelo preço de cada item.
            //Soma tudo na variável valorTotal
            valorTotal += qtdBlusa * blusa;
            valorTotal += qtdCalca * calca;
            valorTotal += qtdCamiseta * camiseta;
            valorTotal += qtdShort * shortRoupa;


            Console.WriteLine("\n=== Resumo da Compra ===");//Só mostra produtos que o usuário comprou (if (qtd > 0))

            if (qtdBlusa > 0)
                Console.WriteLine($"Blusas: {qtdBlusa} x R$ {blusa:F2} = R$ {(qtdBlusa * blusa):F2}"); //:F2 formata o número com 2 casas decimais.
            if(qtdCalca > 0)
                Console.WriteLine($"Calças: {qtdCalca} x R$ {calca:F2} = R$ {(qtdCalca * calca):F2}"); //Exibe produto, quantidade, valor unitário e total.
            if(qtdCamiseta > 0)
                Console.WriteLine($"Camisetas: {qtdCamiseta} x R$ {camiseta:F2} = R$ {(qtdCamiseta * camiseta):F2}");
            if(qtdShort > 0)
                Console.WriteLine($"Shorts: {qtdShort} x R$ {shortRoupa:F2} = R$ {(qtdShort * shortRoupa):F2}");

            
            Console.WriteLine($"\nValor total da compra: R$ {valorTotal:F2}"); //Mostra o valor final calculado com 2 casas decimais

        }
    }
}
