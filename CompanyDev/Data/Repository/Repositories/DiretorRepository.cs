using Data.Context;
using Domain.Entities;
using System.Data;

namespace Data.Repository.Repositories
{
    public class DiretorRepository : BaseRepository<DiretorEntity>
    {
        public DiretorRepository(MySqlContext context) : base(context) { }

        public async Task<IEnumerable<DiretorEntity>> FilterByName(string nome)
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
