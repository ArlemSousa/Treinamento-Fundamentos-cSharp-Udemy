using ExercicioFixacao;

ContaBancaria contaBancaria = new ContaBancaria();


Console.WriteLine("Entre com o numero da conta: ");
int numeroConta = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o nome do titular da conta: ");
string nomeTitular = Console.ReadLine();

Console.WriteLine("Deseja fazer um deposito inicial? \nS - SIM \n2 - NÂO");
char depositoInicial = char.Parse(Console.ReadLine().ToUpper());


if (depositoInicial == 'S')
{
    Console.WriteLine("Digite o valor do deposito:");
    double valorDeposito = double.Parse(Console.ReadLine());
    contaBancaria = new ContaBancaria(numeroConta, nomeTitular, valorDeposito);
}

Console.WriteLine(contaBancaria);
Console.WriteLine();


Console.WriteLine("Digite agora um valor para depositar na conta:");
double deposito = double.Parse(Console.ReadLine());
contaBancaria.Deposito(deposito);
Console.WriteLine(contaBancaria);
Console.WriteLine();

Console.WriteLine("Digite agora um valor para sacar na conta:");
double saque = double.Parse(Console.ReadLine());
contaBancaria.Saque(saque);
Console.WriteLine(contaBancaria);
Console.WriteLine();




