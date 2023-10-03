using Domain.Entities;

namespace Domain.Request
{
    public class EquipeRequest
    {
        public EquipeRequest()
        {
            
        }

        public string Nome { get; set; }
        public int GerenteId { get; set; }

        public EquipeEntity GetEntity() 
        {
            return new EquipeEntity()
            {
                Nome = Nome,
                GerenteId = GerenteId
            };
        }
    }
}
