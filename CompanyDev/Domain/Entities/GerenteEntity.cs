namespace Domain.Entities
{
    public class GerenteEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public int DonoId { get; set; }
        public int EquipeId { get; set; }
    }
}
