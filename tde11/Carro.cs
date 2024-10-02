public class Carro : Veiculo
{
  private int numeroDePortas;

  public Carro(string marca, string modelo, int ano, int numDePortas):base(marca,modelo,ano)
  {
    numeroDePortas = numDePortas;
  }
 
  public void abrirMalas()
  {
    Console.WriteLine("Porta Malas aberto");
  }
  public void exibirInformacoes()
  {
    Console.WriteLine($"{Marca},{Modelo},{Ano},{numeroDePortas}.");
  }
}