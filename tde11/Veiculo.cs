public class Veiculo{
    protected string Marca;
    protected string Modelo;
    protected int Ano;

    public void Ligar()
    {
        Console.WriteLine("Ligando");
    }
     public void Desligar()
    {
        Console.WriteLine("Desligando");
    }
    public Veiculo(string marca,string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }
}