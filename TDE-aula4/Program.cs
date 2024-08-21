// double saldo = 0;
// bool conta = true;
// double sacar;
// double deposito;

// while(conta){
//     Console.WriteLine("Sistema do banco");
//     Console.WriteLine("1 - Consultar o saldo:");
//     Console.WriteLine("2 - Sacar");
//     Console.WriteLine("3 - Depositar");
//     Console.WriteLine("4 - Sair");

//     Console.WriteLine("Escolha uma opção:");
//     string opcao = Console.ReadLine();


//     switch(opcao){

//         case "1":
//         Console.Write("Seu saldo é:R$"+saldo);
//         break;

//         case "2":
//         Console.WriteLine("Digite o valor que deseja sacar:R$");
//         sacar = Convert.ToDouble(Console.ReadLine());
//         if(saldo >= sacar){
//             saldo-=sacar;
//             Console.WriteLine("seu saldo atual é:" + saldo);
//             Console.WriteLine("Saque realizado com sucesso!");
//         }
//         else{
//             Console.WriteLine("Saldo insufisiente para operação");
//         }
//         break;

//         case "3":
//             Console.WriteLine("Digite o valor que deseja depositar:R$");
//             deposito = Convert.ToDouble(Console.ReadLine());
//             saldo +=deposito;
//             break;

//         case "4":
//         Console.WriteLine("Saindo do sistema");
//         conta = false;
//         break;
//         default:
//         Console.WriteLine("Opção inválida.");
//         break;
        
//     }

// } 

//Calculadora
// double num1;
// double num2;
// bool calc = true;

// while(calc){

//     Console.WriteLine("Digite o primeiro numero: ");
//     num1 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Digite o segundo numero: ");
//     num2 = Convert.ToDouble(Console.ReadLine());  

//     Console.WriteLine("Operações");
//     Console.WriteLine("Selesione uma operação disponivel:");
//     Console.WriteLine("1 - Adição");
//     Console.WriteLine("2 - Subtração");
//     Console.WriteLine("3 - Divisão");
//     Console.WriteLine("4 - Multiplucação");
//     Console.WriteLine("5 - Sair");
//     Console.WriteLine("Escolha uma opção:");
//     string opcao = Console.ReadLine();


//     switch(opcao){

//         case "1":
//         double soma = num1 + num2;
//         Console.WriteLine($"{num1}+{num2}={soma}");
//         break;

//         case "2":
//         double sub = num1 - num2;
//         Console.WriteLine($"{num1}-{num2}={sub}");
//         break;

//         case "3":
//         double div = num1 / num2;
//         Console.WriteLine($"{num1}/{num2}={div}");
//         break;

//         case "4":
//         double mult = num1 * num2; 
//         Console.WriteLine($"{num1}x{num2}={mult}");
//         break;

//         case "5":
//         Console.WriteLine("Saindo do sistema");
//         calc = false;
//         break;

//         default:
//         Console.WriteLine("Opção invalida.");
//         break;
//     }
// }

//Jogo de adivinhação

int numero = 0;
bool adivinha = true;

Random randon = new Random();

int numeroAleatorio;

numeroAleatorio = randon.Next(1, 100);

Console.WriteLine("Numero Aleatório" + numeroAleatorio);

while(adivinha){
    Console.WriteLine("Digite um numero: ");
    numero = Convert.ToInt32(Console.ReadLine());
    if(numero == numeroAleatorio){
        Console.WriteLine("Você acertou");
        adivinha = false;
    }
}

