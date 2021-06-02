using ClinicaMedica.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Business.Interfaces.Repositories
{
    public interface IMedicoRepository : IRepository<Medico>
    {
        Task<IEnumerable<Medico>> ObterMedicosPorEspecialidade(Guid especialidadeId);
        Task<IEnumerable<Medico>> ObterMedicosPorEspecialidades();
        Task<Medico> ObterMedicoEspecialidade(Guid id);
    }
}
