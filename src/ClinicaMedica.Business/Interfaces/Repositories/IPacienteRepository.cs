﻿using ClinicaMedica.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Business.Interfaces.Repositories
{
    public interface IPacienteRepository : IRepository<Paciente>
    {
        Task<Paciente> ObterPacienteEndereco(Guid id);
    }
}
