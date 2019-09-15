using System;

namespace Alugueis
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vec = new Estudante[10];
            Console.WriteLine("Digite o valor de Estudantes que vao entrar:");
            int n = int.Parse(Console.ReadLine());

            if (n > 10)
            {
                Console.WriteLine("So possue 10(dez) quartos disponiveis!");
                n = 10;
            }

            for (int i=0; i<n; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vec[quarto-1] = new Estudante(quarto, nome, email);
                Console.Clear();
            }

            Console.WriteLine("Quatos Alugados");
            for (int i=0; i<10;i++)
            {
                if (vec[i]!=null)
                {
                    Console.WriteLine(vec[i]);
                }
            }
        }
    }
}
