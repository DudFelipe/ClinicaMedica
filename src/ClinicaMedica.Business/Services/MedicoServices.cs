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
    public class MedicoServices : BaseService, IMedicoService
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoServices(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        public async Task Adicionar(Medico medico)
        {
            await _medicoRepository.Adicionar(medico);
        }

        public async Task Atualizar(Medico medico)
        {
            await _medicoRepository.Atualizar(medico);
        }

        public async Task<IEnumerable<Medico>> ObterMedicosPorEspecialidade(Guid especialidadeId)
        {
            return await _medicoRepository.ObterMedicosPorEspecialidade(especialidadeId);
        }

        public async Task<IEnumerable<Medico>> ObterMedicosPorEspecialidades()
        {
            return await _medicoRepository.ObterMedicosPorEspecialidades();
        }

        public async Task<Medico> ObterMedicoEspecialidade(Guid id)
        {
            return await _medicoRepository.ObterMedicoEspecialidade(id);
        }

        public async Task<Medico> ObterPorId(Guid id)
        {
            return await _medicoRepository.ObterPorId(id);
        }

        public async Task Remover(Guid id)
        {
            await _medicoRepository.Remover(id);
        }

        public void Dispose()
        {
            _medicoRepository?.Dispose();
        }
    }
}
