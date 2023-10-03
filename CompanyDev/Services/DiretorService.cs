using Data.Repository.Repositories;
using Domain.Entities;
using Domain.Request;

namespace Services
{
    public class DiretorService
    {
        private readonly DiretorRepository _repository;

        public DiretorService(DiretorRepository repository)
        {
            _repository = repository;
        }

        public async Task<DiretorEntity> GetDiretorById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<DiretorEntity> CreateDiretor(DiretorRequest diretor)
        {
            return await _repository.InsertAsync(diretor.GetEntity());
        }

        public async Task<bool> DeleteDiretor(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<DiretorEntity>> FilterByName(string nome)
        {
            return await _repository.FilterByName(nome);
        }
    }
}
