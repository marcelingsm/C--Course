using System;


namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.Write("Insira o Nome do produto: ");
            product.Name = Console.ReadLine();
            Console.Write("Insira o preco do produto: ");
            product.Preco = double.Parse(Console.ReadLine());
            Console.Write("Insira o quantidade no estoque: ");
            product.Amount = int.Parse(Console.ReadLine());



            int menu = 0;
            int amount = 0;
            while (menu != 4)
            {

                Console.WriteLine(
                "(1) Inserir no estoque\n"
                + "(2) Remover do estoque\n"
                + "(3) Imprimi\n"
                + "(4) Sair"
                 );

                Console.WriteLine("Insira a opicao desejada:");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("quantos deseja Adicionar?");
                        amount = int.Parse(Console.ReadLine());
                        product.addProduct(amount);
                        break;
                    case 2:
                        Console.WriteLine("quantos deseja Remover?");
                        amount = int.Parse(Console.ReadLine());
                        product.removeProduct(amount);
                        break;
                    case 3:
                        Console.WriteLine(product);
                        Console.ReadLine();
                        break;

                    default:
                        break;
                }
                Console.Clear();
            }
        }
    }
}
