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
        public Task Remover(Guid id);
        public void Dispose();
    }
}
