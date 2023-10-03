using Domain.Entities;

namespace Domain.Request
{
    public class FuncionarioRequest
    {
        public FuncionarioRequest()
        {
            
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public int EquipeId { get; set; }
        public int GerenteId { get; set; }

        public FuncionarioEntity GetEntity()
        {
            return new FuncionarioEntity()
            {
                Nome = Nome,
                Email = Email,
                Telefone = Telefone,
                Idade = Idade,
                Cpf = Cpf,
                EquipeId = EquipeId,
                GerenteId = GerenteId
            };
        }
    }
}
