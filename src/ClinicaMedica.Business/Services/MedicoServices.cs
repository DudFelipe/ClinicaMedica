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
