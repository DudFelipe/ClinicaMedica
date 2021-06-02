using ClinicaMedica.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Business.Interfaces.Repositories
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        public Task<Endereco> ObterEnderecoPorPaciente(Guid idPaciente);
    }
}
