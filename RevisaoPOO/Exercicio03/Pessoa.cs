using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio03
{
    public class Pessoa
    {
        public string Nome { get; set; }

        private int idade;

        public int Idade
        {
            get { return idade; }
            set
            {
                if (value > 0)
                {
                    idade = value;
                }
                else
                {
                    Console.WriteLine("Idade inválida! Deve ser maior que zero.");
                }
            }
        }
    }
}
