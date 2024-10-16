public class Carro : Veiculo,IFreavel,  IAceleravel
{


    public Carro(string marca, string modelo):base(marca, modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }
    public override void Ligar()
    {
        Console.WriteLine("O carro ests ligado");
    }
    public void Acelerar()
    {
        Console.WriteLine($"O carro {Marca}, {Modelo} esta acelerando");
    }
    public void Frear()
    {
        Console.WriteLine($"O carro {Marca}, {Modelo} esta freando");

    }
}