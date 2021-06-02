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
    public class EspecialidadeRepository : Repository<Especialidade>, IEspecialidadeRepository
    {
        public EspecialidadeRepository(MeuDbContext db) : base(db)
        {
        }

        //public async Task<Especialidade> ObterEspecialidadePorMedico(Guid medicoId)
        //{
        //    return await Db.Especialidades.AsNoTracking()
        //        .FirstOrDefaultAsync(m => m. == medicoId);
        //}
    }
}
