using ClinicaMedica.Business.Interfaces;
using ClinicaMedica.Business.Interfaces.Repositories;
using ClinicaMedica.Business.Interfaces.Services;
using ClinicaMedica.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Business.Services
{
    public class PacienteService : BaseService, IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IEnderecoRepository _enderecoRepository;

        public PacienteService(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public async Task Adicionar(Paciente paciente)
        {
            await _pacienteRepository.Adicionar(paciente);
        }

        public async Task Atualizar(Paciente paciente)
        {
            await _pacienteRepository.Atualizar(paciente);
        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            await _enderecoRepository.Atualizar(endereco);
        }

        public async Task Remover(Guid id)
        {
            await _pacienteRepository.Remover(id);
        }

        public void Dispose()
        {
            _pacienteRepository?.Dispose();
        }

        public async Task<IEnumerable<Paciente>> ObterPacientesPorEndereco(Guid enderecoId)
        {
            return await _pacienteRepository.ObterPacientesPorEndereco(enderecoId);
        }

        public async Task<IEnumerable<Paciente>> ObterPacientesPorEndereco()
        {
            return await _pacienteRepository.ObterPacientesPorEndereco();
        }

        public async Task<Paciente> ObterPacienteEndereco(Guid id)
        {
            return await _pacienteRepository.ObterPacienteEndereco(id);
        }
    }
}
