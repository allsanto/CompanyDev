using Domain.Entities;

namespace Domain.Request
{
    public class DiretorRequest
    {
        public DiretorRequest() { }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }

        public DiretorEntity GetEntity()
        {
            return new DiretorEntity()
            {
                Nome = Nome,
                Email = Email,
                Telefone = Telefone,
                Idade = Idade,
                Cpf = Cpf
            };
        }
    }
}
