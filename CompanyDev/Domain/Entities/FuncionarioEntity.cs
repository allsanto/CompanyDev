namespace Domain.Entities
{
    public class FuncionarioEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public int EquipeId { get; set; }
        public int GerenteId { get; set; }
    }
}
