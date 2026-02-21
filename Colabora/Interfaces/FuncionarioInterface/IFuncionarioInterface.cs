using Colabora.Models;

namespace Colabora.Interfaces.FuncionarioInterface
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios();
        Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id);
        Task<ServiceResponse<List<FuncionarioModel>>> CreatedFuncionario(FuncionarioModel novoFuncionario);
        Task<ServiceResponse<List<FuncionarioModel>>> UpdatedFuncionario(FuncionarioModel editadoFuncionario);
        Task<ServiceResponse<List<FuncionarioModel>>> RemovedFuncionario(int id);
        Task<ServiceResponse<List<FuncionarioModel>>> InactivedFuncionario(int id);
    }
}
