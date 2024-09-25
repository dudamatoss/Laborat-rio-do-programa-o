Retangulo re1 = new Retangulo();
Retangulo re2 = new Retangulo(2);
Retangulo re3 = new Retangulo(2,4);

Console.WriteLine($"Retângulo 1: Área = {re1.CalcularArea()}, Perímetro = {re1.CalcularPerimetro()}");
Console.WriteLine($"Retângulo 2: Área = {re2.CalcularArea()}, Perímetro = {re2.CalcularPerimetro()}");
Console.WriteLine($"Retângulo 3: Área = {re3.CalcularArea()}, Perímetro = {re3.CalcularPerimetro()}");

re3.Redimencionar(2);
Console.WriteLine($"Retângulo 3 Redimensionado: Área = {re3.CalcularArea()}, Perímetro = {re3.CalcularPerimetro()}");

re2.Redimencionar(10,15);
Console.WriteLine($"Retângulo 2 Redimensionado: Área = {re2.CalcularArea()}, Perímetro = {re2.CalcularPerimetro()}");
