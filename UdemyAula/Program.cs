using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace UdemyAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine()!;
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Quantidadeno no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine()!);
            Console.WriteLine(string.Create(CultureInfo.InvariantCulture, $"Dados do produto: {produto.Nome}, $ {produto.Preco}, Total: $ {produto.ValorTotalEmEstoque()}"));

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()!));

            Console.WriteLine(string.Create(CultureInfo.InvariantCulture, $"Dados atualizados: {produto.Nome}, $ {produto.Preco}, Total: $ {produto.ValorTotalEmEstoque()}"));

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()!));

            Console.WriteLine(string.Create(CultureInfo.InvariantCulture, $"Dados atualizados: {produto.Nome}, $ {produto.Preco}, Total: $ {produto.ValorTotalEmEstoque()}"));

            Console.WriteLine(produto);


        }
    }
}