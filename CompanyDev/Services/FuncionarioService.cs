using Data.Repository.Repositories;
using Domain.Entities;
using Domain.Request;

namespace Services
{
    public class FuncionarioService
    {
        private readonly FuncionarioRepository _repository;

        public FuncionarioService(FuncionarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<FuncionarioEntity> GetFuncionarioById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<FuncionarioEntity> CreateFuncionario(FuncionarioRequest funcionario)
        {
            if (funcionario.EquipeId > 0)
                throw new Exception("IquipeId não pode ser null");

            if (funcionario.GerenteId > 0)
                throw new Exception("GerenteId não pode ser null");

            return await _repository.InsertAsync(funcionario.GetEntity());
        }

        public async Task<bool> DeleteFuncionario(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<FuncionarioEntity>> FilterByName(string nome)
        {
            return await _repository.FilterByName(nome);
        }
    }
}
