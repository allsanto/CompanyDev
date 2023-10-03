using Data.Context;
using Domain.Entities;

namespace Data.Repository.Repositories
{
    public class GerenteRepository : BaseRepository<GerenteEntity>
    {
        public GerenteRepository(MySqlContext context) : base(context) { }

        public async Task<IEnumerable<GerenteEntity>> FilterByName(string nome)
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
