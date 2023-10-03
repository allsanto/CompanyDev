using Domain.Entities;

namespace Domain.Request
{
    public class GerenteRequest
    {
        public GerenteRequest()
        {
            
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public int DonoId { get; set; }
        public int EquipeId { get; set; }

        public GerenteEntity GetEntity()
        {
            return new GerenteEntity()
            {
                Nome = Nome,
                Email = Email,
                Telefone = Telefone,
                Idade = Idade,
                Cpf = Cpf,
                DonoId = DonoId
            };
        }
    }
}
