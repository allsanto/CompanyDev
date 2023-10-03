namespace Domain.Entities
{
    public class EquipeEntity : BaseEntity
    {
        public string Nome { get; set; }
        public int GerenteId { get; set; }
    }
}
