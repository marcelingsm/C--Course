using System;
using System.Globalization;

namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            String produto1 = "Computador";
            String produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1
                + ", cujo preco é $ "
                + preco1.ToString("F2")
                + "\n" + produto2
                + ", cujo preco é $ "
                + preco2.ToString("F2")
                + "\n\n" + "Registro: "
                + idade + " ano de idade, codigo "
                + codigo + " e genero: "
                + genero + "\n\n"
                + "Medida com oito casas decimais: "
                + medida.ToString("F8")
                + "\nArredodado (Tres casas decimais): "
                + medida.ToString("F3")
                + "\nSeparador decimal invariant culture: "
                + medida.ToString("F3", CultureInfo.InvariantCulture)
                );
        }
    }
}