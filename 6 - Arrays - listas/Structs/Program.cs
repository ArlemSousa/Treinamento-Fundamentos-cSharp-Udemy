namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inicialização da struct
            Point p;

            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            //outra forma de incializaçlão da struct
            p = new Point();
            Console.WriteLine(p);
        }
    }
}
