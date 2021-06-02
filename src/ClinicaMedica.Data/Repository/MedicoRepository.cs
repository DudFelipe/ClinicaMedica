using ClinicaMedica.Business.Interfaces.Repositories;
using ClinicaMedica.Business.Models;
using ClinicaMedica.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Data.Repository
{
    public class MedicoRepository : Repository<Medico>, IMedicoRepository
    {
        public MedicoRepository(MeuDbContext db) : base(db)
        {

        }

        public async Task<Medico> ObterMedicoPorEspecialidade(Guid especialidadeId)
        {
            return await Db.Medicos.AsNoTracking()
                .Include(e => e.Especialidade)
                .FirstOrDefaultAsync(m => m.EspecialidadeId == especialidadeId);
        }
    }
}
