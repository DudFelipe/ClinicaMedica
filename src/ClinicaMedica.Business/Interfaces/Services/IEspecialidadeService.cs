using ClinicaMedica.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Business.Interfaces.Services
{
    public interface IEspecialidadeService
    {
        public Task Adicionar(Especialidade especialidade);
        public Task Atualizar(Especialidade especialidade);
        public Task<IEnumerable<Especialidade>> ObterTodos();
        public Task<Especialidade> ObterEspecialidade(Guid id);
        public Task Remover(Guid id);
        public void Dispose();
    }
}
