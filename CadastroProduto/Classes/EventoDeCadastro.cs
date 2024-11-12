using System.Security.Cryptography.X509Certificates;

namespace CadastroProduto.Classes;

public class EventoDeCadastro
{

    private List<Produto> listProduto = new List<Produto>();
    

    public void InsereProduto(){
        Console.WriteLine("Informe o código e o nome do produto: ");
        var cdProduto = int.Parse(Console.ReadLine());
        if (listProduto.Any(p => p.cdProduto == cdProduto))
        {
            Console.WriteLine("Produto já cadastrado");            
        }else{
            var nmProduto = Console.ReadLine(); 

            
            Produto produto = new Produto(); 
            produto.cdProduto = cdProduto;
            produto.nmProduto = nmProduto;
            listProduto.Add(produto);
        }
    }

    public void ExcluiProduto(){
        Console.WriteLine("Informe o produto que deseja excluir: ");
        var cdProduto = int.Parse(Console.ReadLine());

        if (listProduto.Any(p => p.cdProduto == cdProduto))
        {
            Produto _produto = listProduto.FirstOrDefault(a => a.cdProduto == cdProduto);
            listProduto.Remove(_produto);
        }
    }

    public void ListarProdutos(){
        if (listProduto.Any()){
            Console.WriteLine("Os produtos listados são: ");
            foreach (var item in listProduto)
            {
               Console.WriteLine($"{item.cdProduto} - {item.nmProduto}");
            }
        }else{
            Console.WriteLine("Nenhum produto na lista.");
        }
    }

    public void AlteraProduto(){

        Console.WriteLine("Informe o código do produto: ");
        int cdProduto = int.Parse(Console.ReadLine());

        Produto _produto = listProduto.FirstOrDefault(a => a.cdProduto == cdProduto);

        if (_produto != null)
        {
            Console.WriteLine("Informa o novo código: ");
            var cdNewProduto = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o novo nome: ");
            var nmNewProduto = Console.ReadLine();

            _produto.cdProduto = cdNewProduto;
            _produto.nmProduto = nmNewProduto;
        }
    }

}
