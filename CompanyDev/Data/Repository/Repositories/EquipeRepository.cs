using Data.Context;
using Domain.Entities;

namespace Data.Repository.Repositories
{
    public class EquipeRepository : BaseRepository<EquipeEntity>
    {
        public EquipeRepository(MySqlContext context) : base(context) { }

        public async Task<IEnumerable<EquipeEntity>> FilterByName(string nome)
        {
            try
            {
                return this.GetAll().Where(x => x.Nome == nome).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
