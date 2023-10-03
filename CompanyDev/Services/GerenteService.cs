using Data.Repository.Repositories;
using Domain.Entities;
using Domain.Request;

namespace Services
{
    public class GerenteService
    {
        private readonly GerenteRepository _repository;

        public GerenteService(GerenteRepository repository)
        {
            _repository = repository;
        }

        public async Task<GerenteEntity> GetGerenteById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<GerenteEntity> CreateGerente(GerenteRequest Gerente)
        {
            return await _repository.InsertAsync(Gerente.GetEntity());
        }

        public async Task<bool> DeleteGerente(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<GerenteEntity>> FilterByName(string nome)
        {
            return await _repository.FilterByName(nome);
        }
    }
}
