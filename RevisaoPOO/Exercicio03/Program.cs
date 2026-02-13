using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa01 = new Pessoa();

            pessoa01.Nome = "Maria";
            pessoa01.Idade = 17;  
            pessoa01.Idade = -5; 

            Console.WriteLine($"Nome: {pessoa01.Nome}");
            Console.WriteLine($"Idade: {pessoa01.Idade}");
        }
    }
}
