using System;
using System.Collections.Generic;

namespace CourseList
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> CourseA = new HashSet<int>();
            HashSet<int> CourseB = new HashSet<int>();
            HashSet<int> CourseC = new HashSet<int>();

            Console.Write("Quantos alunos possui o curso A? ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                CourseA.Add(x);
            }
            Console.Write("Quantos alunos possui o curso B? ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                CourseB.Add(x);
            }
            Console.Write("Quantos alunos possui o curso C? ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                CourseC.Add(x);
            }
            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(CourseA);
            Novo.UnionWith(CourseB);
            Novo.UnionWith(CourseC);
            Console.WriteLine("Total de Alunos: " + Novo.Count);
            Console.ReadLine();
        }
    }
}
