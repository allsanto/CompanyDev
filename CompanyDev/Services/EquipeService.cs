using Data.Repository.Repositories;
using Domain.Entities;
using Domain.Request;

namespace Services
{
    public class EquipeService
    {
        private readonly EquipeRepository _repository;

        public EquipeService(EquipeRepository repository)
        {
            _repository = repository;
        }

        public async Task<EquipeEntity> GetEquipeById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<EquipeEntity> CreateEquipe(EquipeRequest equipe)
        {
            if (equipe.GerenteId > 0)
            {
                return await _repository.InsertAsync(equipe.GetEntity());
            }
            else
            {
                throw new Exception("Gerente não pode ser null");
            }
        }

        public async Task<bool> DeleteEquipe(int id)
        {
            if (id > 0)
            {
                return await _repository.DeleteAsync(id);
            }
            else
            {
                throw new Exception("id não pode ser null");
            }
        }

        public async Task<IEnumerable<EquipeEntity>> FilterByName(string nome)
        {
            return await _repository.FilterByName(nome);
        }
    }
}
