using System.Runtime.CompilerServices;

class Produto
{
    public string nome;
    public int quantidade;
    public double preco;
    public void AdicionarEstoque(int valor)
    {
        if (valor > 0)
        {
            quantidade += valor;
            Console.WriteLine($"A quantidad {valor} foi adicionada ao produto {nome}");
        }
        else
        {
            Console.WriteLine("ERRO:Digite um valor válido");
            Console.ReadKey();
        }

    }
    public void RemoverEstoque(int valor)
    {
        if (valor > 0 && valor <= quantidade)
        {
            quantidade -= valor;
            Console.WriteLine($"A quantidade {valor} foi removida do produto {nome}");

        }
        else if (valor <= 0)
        {
            Console.WriteLine("O valor informado é menor ou igual a 0");
        }
        else
        {
            Console.WriteLine("O volor informado é maior que a quantidade disponível no estoque ");
            Console.ReadKey();
        }

    }
    public double CalcularValorEstoque()
    {
        return quantidade * preco;
    }
    public void DefinirValores()
    {
        Console.WriteLine("Informe o nome do produto: ");
        nome = Console.ReadLine();
        Console.WriteLine("Informe a quantidade do produto: ");
        quantidade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o prço do pruduto: R$");
        preco = Convert.ToDouble(Console.ReadLine());

    }
    public void ExibirInformacoes()
    {
        Console.WriteLine("Nome do produto: " + nome);
        Console.WriteLine(" Quantidade do produto: " + quantidade);
        Console.WriteLine("Preço unitário do prduto: R$" + preco);
        Console.WriteLine("Valor total em estoque:R$"+CalcularValorEstoque());


    }
}