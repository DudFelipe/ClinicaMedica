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
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext db) : base(db)
        {
        }

        public async Task<Endereco> ObterEnderecoPorPaciente(Guid pacienteId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(p => p.PacienteId == pacienteId);
        }
    }
}
