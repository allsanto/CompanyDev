using Data.Context;
using Domain.Entities;

namespace Data.Repository.Repositories
{
    public class FuncionarioRepository : BaseRepository<FuncionarioEntity>
    {
        public FuncionarioRepository(MySqlContext context) : base(context) { }

        public async Task<IEnumerable<FuncionarioEntity>> FilterByName(string nome)
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
