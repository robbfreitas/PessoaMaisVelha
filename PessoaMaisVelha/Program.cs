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

            Console.WriteLine("Dado da primeira pessoa: ");
            p1.nomePessoa = Console.ReadLine();
            p1.idadePessoa = int.Parse(Console.ReadLine());

            Console.WriteLine("Dado da segunda pessoa: ");
            p2.nomePessoa = Console.ReadLine();
            p2.idadePessoa = int.Parse(Console.ReadLine());

            if (p1.idadePessoa > p2.idadePessoa)
            {
                Console.WriteLine("Pessoa mais velha é {0}", p1.nomePessoa);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha é {0}", p2.nomePessoa);
            }
        }
    }
}