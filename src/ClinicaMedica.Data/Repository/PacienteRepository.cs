using ClinicaMedica.Business.Interfaces;
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
    public class PacienteRepository : Repository<Paciente>, IPacienteRepository
    {
        public PacienteRepository(MeuDbContext db) : base(db)
        {
        }

        public async Task<Paciente> ObterPacienteEndereco(Guid id)
        {
            return await Db.Pacientes.AsNoTracking()
                    .Include(e => e.Endereco)
                    .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
