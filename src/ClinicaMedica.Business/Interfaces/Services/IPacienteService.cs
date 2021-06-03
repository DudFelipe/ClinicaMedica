using ClinicaMedica.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Business.Interfaces.Services
{
    public interface IPacienteService
    {
        public Task Adicionar(Paciente paciente);
        public Task Atualizar(Paciente paciente);
        public Task AtualizarEndereco(Endereco endereco);
        Task<IEnumerable<Paciente>> ObterPacientesPorEndereco(Guid enderecoId);
        Task<IEnumerable<Paciente>> ObterPacientesPorEndereco();
        Task<Paciente> ObterPacienteEndereco(Guid id);
        public Task Remover(Guid id);
        public void Dispose();
    }
}
