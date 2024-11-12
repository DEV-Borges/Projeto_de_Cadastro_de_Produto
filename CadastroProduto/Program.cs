using CadastroProduto.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        bool exibirMenu = true;

        EventoDeCadastro e = new EventoDeCadastro();
        
        while (exibirMenu)
        {

            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar Produto");
            Console.WriteLine("2 - Remover Produto");
            Console.WriteLine("3 - Alterar Produto");
            Console.WriteLine("4 - Listar Produtos");
            Console.WriteLine("5 - Encerrar");

            switch (Console.ReadLine())
            {
                case "1":
                    e.InsereProduto();
                    break;

                case "2":
                    e.ExcluiProduto();
                    break;

                case "3":
                    e.AlteraProduto();
                    break;

                case "4":
                    e.ListarProdutos();
                    break;
                case "5":
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }
    }
}