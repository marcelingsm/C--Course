using ProductLabel.entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProductLabel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.WriteLine("Enter the mumber of products:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #" + i + "data:");
                Console.Write("Common, used or imported?(c/u/i)? ");
                char menu = char.Parse(Console.ReadLine());


                switch (menu)
                {
                    case 'C':
                    case 'c':
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Price: ");
                        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new Product(name, price));
                        break;
                    case 'U':
                    case 'u':
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Price: ");
                        price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        Console.Write("Manufacture date(DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, price,date));
                        break;
                    case 'I':
                    case 'i':
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Price: ");
                        price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Curstoms fee: ");
                        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new ImportedProduct(name, price, fee));
                        break;

                }
            }
            Console.Clear();
            Console.WriteLine("Price TAGS:");
            foreach (Product p in list)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
