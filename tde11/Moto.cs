public class Moto : Veiculo
{
    private bool temBagageiro;

    public void darGrau()
   {
     Console.WriteLine("Randandandan");
    }
    public void exibirInformacoes()
  {
    Console.WriteLine($"{Marca},{Modelo},{Ano},{temBagageiro}.");
  }
  public Moto(string marca, string modelo, int ano, bool temBag): base(marca, modelo, ano)
  {
    temBagageiro = temBag;
  }
    
}