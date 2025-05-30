using System;

namespace ExercicioOOP
{
    class Pessoa
    {
        public string nome;
        public int idade;

        public void ApresentarSe()
        {
            Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos.");
        }

        public void FazerAniversario()
        {
            idade++;
            Console.WriteLine($"{nome} fez aniversário! Agora tem {idade} anos.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Maria";
            pessoa1.idade = 25;

            Pessoa pessoa2 = new Pessoa();
            pessoa2.nome = "João";
            pessoa2.idade = 30;

            pessoa1.ApresentarSe();
            pessoa2.ApresentarSe();

            pessoa1.FazerAniversario();

            Console.ReadKey();
        }
    }
}