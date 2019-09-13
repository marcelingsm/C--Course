using System;
using System.Globalization;

namespace Estrutura_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            exe5();
        }


        static void exe1()
        {
            Console.WriteLine("Escreva dois numeros que voce deseja SOMAR: (Enter para confirmar) ");
            int result = int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine());
            Console.Write("SOMA = " + result);
        }


        static void exe2()
        {
            double PI = 3.14159;

            Console.WriteLine("Insira o raio do circulo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = PI * (raio * raio);
            Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }

        static void exe3()
        {
            Console.WriteLine("Insira 4 valores");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = a * b - c * d;

            Console.WriteLine("Direfenca: " + diferenca);
        }

        static void exe4()
        {
            Console.Write("Numero do funcionario: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Numero de horas trabalhadas: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Valor do salario por horas: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double totalSalary = hours * salary;

            Console.WriteLine("ID = " + id + "\nSALARY = U$ " + totalSalary.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void exe5()
        {
            Console.WriteLine("#Peca 1\nInsira o id, quantidade e valor unitario: ");
            String[] text = Console.ReadLine().Split(" ");
            int id1 = int.Parse(text[0]);
            int quant1 = int.Parse(text[1]);
            double value1 = double.Parse(text[2],CultureInfo.InvariantCulture);

            Console.WriteLine("#Peca 2\nInsira o id, quantidade e valor unitario: ");
            text = Console.ReadLine().Split(" ");
            int id2 = int.Parse(text[0]);
            int quant2 = int.Parse(text[1]);
            double value2 = double.Parse(text[2], CultureInfo.InvariantCulture);

            double total = (quant1*value1) + (quant2*value2);

            Console.WriteLine("Valor total: "+ total.ToString("F2",CultureInfo.InvariantCulture));
        }

        static void exe6()
        {
            double PI = 3.14159;

            Console.WriteLine("Insira os tres valores:");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double triagulo = (a*c)/2;
            double circulo = PI * c * c;
            double trapezio = ((a+b)*c)/2;
            double quadrado = b * b;
            double retangulo = a * b;



            Console.WriteLine("Triagulo: " + triagulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }

    }
}
