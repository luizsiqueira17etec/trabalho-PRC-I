using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaaaaaaaaaaaaaaaaaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b;
            string nome;
            string sobrenome;

            a = 10;
            b = 23.4;

            Console.WriteLine("qual seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("qual seu sobrenome:");
            sobrenome = Console.ReadLine();

            Console.WriteLine("escrever na tela");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(nome+" "+sobrenome);

            Console.ReadKey();
        }
    }
}
