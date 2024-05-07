namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando uma lista vazia chamada lista
            List<string> lista = new List<string>();

            List<string> lista2 = new List<string> { "arlem", "sousa"};

            lista2.Add("chico");
            lista2.Add("camelo");
           

            foreach( string listaImprime in lista2)
            {
                Console.WriteLine(listaImprime); 
            }


            //insert posso informar o indice onde quero inserir na lista
            lista2.Insert(2, "marcos");


            //procurar um valor e retornar v ou f 
            string s1 = lista2.Find(Teste);
            Console.WriteLine("Primeiro cara que começa com s: "+ s1);


            //fazendo a mesma coisa com expressao lambda, sem chamar a função Teste()
            string s2 = lista2.Find(x => x[0] == 'c');
            Console.WriteLine(s2);

            //ultima ocorrencia de quem começa com a letra c
            string s3 = lista2.FindLast(x => x[0] == 'c');
            Console.WriteLine(s3);


            //achar quem está na primeira posição da lista com a letra c, retornando entao o numero da posição
            int posicao = lista2.FindIndex(x => x[0] == 'c');


            //achar quem está na ultima posição da lista com a letra c, retornando entao o numero da posição
            int posicao2 = lista2.FindLastIndex(x => x[0] == 'c');


            //filtrar na lista todo mundo que tem 5 caracteres
            List<string> lista3 = lista2.FindAll(x => x.Length == 5);
            foreach (string obj in lista3) {
                Console.WriteLine(obj);
            }



            //remover unico item
            lista2.Remove("arlem");

            //remover todo mundo que começa com a letra c
            lista2.RemoveAll(x => x[0] == 'c');
            foreach (string obj in lista2)
            {
                Console.WriteLine(obj);
            }

            //remover um item de determinada position
            lista2.RemoveAt(3);
                     

        }

        static bool Teste(string s)
        {
            return s[0] == 's';
        }
    }
}
