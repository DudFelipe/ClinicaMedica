using ClinicaMedica.Business.Interfaces.Repositories;
using ClinicaMedica.Business.Interfaces.Services;
using ClinicaMedica.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Business.Services
{
    public class EspecialidadeService : BaseService, IEspecialidadeService
    {
        private readonly IEspecialidadeRepository _especialidadeRepository;

        public EspecialidadeService(IEspecialidadeRepository especialidadeRepository)
        {
            _especialidadeRepository = especialidadeRepository;
        }

        public async Task Adicionar(Especialidade especialidade)
        {
            await _especialidadeRepository.Adicionar(especialidade);
        }

        public async Task Atualizar(Especialidade especialidade)
        {
            await _especialidadeRepository.Atualizar(especialidade);
        }

        public async Task<IEnumerable<Especialidade>> ObterTodos()
        {
           return await _especialidadeRepository.ObterTodos();
        }

        public async Task<Especialidade> ObterEspecialidade(Guid id)
        {
            return await _especialidadeRepository.ObterPorId(id);
        }

        public async Task Remover(Guid id)
        {
            await _especialidadeRepository.Remover(id);
        }

        public void Dispose()
        {
            _especialidadeRepository?.Dispose();
        }
    }
}
