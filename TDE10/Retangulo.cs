public class Retangulo
{
    double largura;
    double altura;

    public Retangulo()
    {
        largura = 0;
        altura = 0;

    }
    public Retangulo(double valor)
    {
        altura = valor;
        largura = valor;
    }
    public Retangulo(double largura, double altura)
    {
        this.altura = altura;

        this.largura = largura;

    }
    public double CalcularArea()
    {
       return largura * altura;
    }
    public double CalcularPerimetro()
    {
        return(largura + altura) * 2;
    
    }
    public void Redimencionar()
    {

    }
    public void Redimencionar(double fator)
    {
        largura*=fator;
        altura*=fator;
    }
    public void Redimencionar (double altura, double largura){
        this.altura =altura;
        this.largura=largura;
    }
}

