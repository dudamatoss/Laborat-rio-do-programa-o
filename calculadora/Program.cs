Calculadora calc = new Calculadora();
Console.WriteLine("Informe um valor para x:");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe um valor para y:");
double y = Convert.ToDouble(Console.ReadLine());


double resultadoSoma = calc.Somar(x,y);
Console.WriteLine($"O resultado da soma enter {x} e {y} é : {resultadoSoma}");

Console.WriteLine($"O resultado da subtração é: {calc.Subtrair(x,y)} ");

Console.WriteLine($"O resultado da multiplicação é: {calc.Multiplicacao(x,y)} ");

Console.WriteLine($"O resultado da divisão é: {calc.Dividir(x,y)} ");
