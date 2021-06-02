using ClinicaMedica.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Business.Interfaces.Services
{
    public interface IMedicoService
    {
        public Task Adicionar(Medico medico);
        public Task Atualizar(Medico medico);
        Task<IEnumerable<Medico>> ObterMedicosPorEspecialidade(Guid especialidadeId);
        Task<IEnumerable<Medico>> ObterMedicosPorEspecialidades();
        Task<Medico> ObterMedicoEspecialidade(Guid id);
        public Task<Medico> ObterPorId(Guid id);
        public Task Remover(Guid id);
        public void Dispose();
    }
}
