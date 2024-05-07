namespace MembrosEstaticosExercicio
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //Calculadora calc = new Calculadora();

            Console.WriteLine("Entre com o valor do raio!");
            double raio = double.Parse(Console.ReadLine());

            //double circ = calc.CalcularCircunferencia(raio);
            double circ = Calculadora.CalcularCircunferencia(raio);
           
            Console.WriteLine("Circunferencia: " + circ);
        }

        
    }
}
