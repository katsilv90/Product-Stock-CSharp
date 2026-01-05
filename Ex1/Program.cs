using Ex1;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // Configuração para suportar caracteres Unicode no console
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // Código do programa principal
        // Criação de um objeto Produto e interação com o usuário
        Produto produto = new Produto();
        Console.WriteLine("Insira os dados do produto:");
        Console.Write("Nome: ");
        produto.Nome = Console.ReadLine();
        Console.Write("Preço: ");
        produto.Preco = double.Parse(Console.ReadLine()!);
        Console.Write("Quantidade em estoque: ");
        produto.Stock = int.Parse(Console.ReadLine()!);
        Console.WriteLine();
        Console.WriteLine("Dados do produto: " + produto);
        Console.WriteLine();
        // Adição e remoção de produtos do estoque
        Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
        int quantidade = int.Parse(Console.ReadLine()!);
        produto.AdicionarProdutos(quantidade);
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + produto);
        Console.WriteLine();
        Console.Write("Digite o número de produtos a serem removidos do estoque: ");
        quantidade = int.Parse(Console.ReadLine()!);
        produto.RemoverProdutos(quantidade);
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + produto);
        Console.WriteLine();
    }
}