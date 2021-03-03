namespace exercicio
{
    public class Pensionato
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Pensionato(string nome, string email) {
            Nome = nome;
            Email = email;
        }
    }
}