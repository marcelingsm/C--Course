
namespace Alugueis
{
    class Estudante
    {
        public int NumeroQuarto { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }


        public Estudante(int NumeroQuarto,string Nome, string Email)
        {
            this.NumeroQuarto = NumeroQuarto;
            this.Nome = Nome;
            this.Email = Email;
        }

        public override string ToString()
        {
            return "Nome: "
                + Nome
                + "-  Email: "
                + Email
                + "-  Quarto: "
                + NumeroQuarto;
        }
    }
}
