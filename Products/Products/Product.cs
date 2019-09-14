
namespace Products
{
    class Product
    {
        public string Name;
        public double Preco;
        public int Amount;


        public double totalValueStock()
        {
            return Preco * Amount;
        }

        public void addProduct(int Amount)
        {
            this.Amount += Amount;
        }

        public void removeProduct(int Amount)
        {
            this.Amount -= Amount;
        }


        public override string ToString()
        {
            return "Dados do produto: "
                 + Name
                 + ", R$ "
                 + Preco.ToString("F2")
                 + ", "
                 + Amount
                 + " Unidades, Total: R$"
                 + totalValueStock().ToString("F2");
        }
    }
}
