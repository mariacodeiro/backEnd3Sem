using System;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa01 = new Pessoa("Maria", 17);

            Console.WriteLine($"Nome: {pessoa01.Nome}");
            Console.WriteLine($"Idade: {pessoa01.Idade}");
        }
    }
}

