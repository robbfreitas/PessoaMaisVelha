using PessoaMaisVelha;
using System.Globalization;

namespace PessoaMaiVelha
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Informe nome e idade da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe nome e idade da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha é {0}", p1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha é {0}", p2.nome);
            }
        }
    }
}