using ExercicioResolvido.Entities;
using ExercicioResolvido.Entities.Enums;



Console.WriteLine("Entre com o nome do departamento: ");
string deptName = Console.ReadLine();

Console.WriteLine("Entre com os dados do trabalhador:");

Console.WriteLine("Nome:"); 
string name = Console.ReadLine();

Console.WriteLine("Informe o nível do profissional (Junior/MidLevel/Senior):"); 
string level = Console.ReadLine();
WorkerLevel workerLevel = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), level);

Console.WriteLine($"Informe a base salarial do funcionário {name}:");
double baseSalary = double.Parse(Console.ReadLine());

//agora vou instanciar meus dois objetos

//criar variavel departamento do tipo Department, usando a sobrecarga do construto que recebe o nome do departamento
Department department = new Department(deptName);

//instanciar objeto worker passando nome, level(), baseSalary,  department()
Worker worker = new Worker(name, workerLevel, baseSalary, department);

//frufru pra pular umas linhas
Console.WriteLine(new string('-',60));
Console.WriteLine();

Console.WriteLine("Quantos contratos deseja cadastar?");
int numContracts = int.Parse(Console.ReadLine());

for (int i = 0; i < numContracts; i++)
{
    //entrar com os dados do contrato
    Console.WriteLine($"Entre com o contrato numero {i}: ");
    Console.WriteLine("Data: ");
    DateTime data = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Informe o valor da hora trabalhada: ");
    double valuePerHour = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a quantidade de horas:");
    int hour = int.Parse(Console.ReadLine());

    //agora vou instanciar um contrato
    HourContract hourContract = new HourContract(data, valuePerHour,hour);

    //agora vou adicionar o contrato instanciado ao tabalhador (worker).
    worker.AddContract(hourContract);
}


//frufru pra pular umas linhas
Console.WriteLine(new string('-', 60));
Console.WriteLine();

//agora vou calcular os valores dos contratos do trabalhador
Console.WriteLine("Entre com mes e ano para calcular o contrato (MM/AAAA) :");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0,2));
int year = int.Parse((monthAndYear.Substring(3)));

//frufru pra pular umas linhas
Console.WriteLine(new string('-', 60));
Console.WriteLine();

//agora vou exibir os objetos
Console.WriteLine("Nome: " + worker.Name);
Console.WriteLine("Deppartamento: " + worker.Department.Name);
Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));




