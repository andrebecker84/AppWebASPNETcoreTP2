namespace AppWebASPNETcoreTP2.Pages
{
    public class Pessoa
    {
        // Atributos encapsulados
        private string? nome;
        private int idade;
        private string? cpf;

        public Pessoa()
        {
            // Construtor padrão
        }

        public Pessoa(string nome, int idade, string cpf)
        {
            // Construtor com parâmetros
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string CPF { get => cpf; set => cpf = value; }
    }
}