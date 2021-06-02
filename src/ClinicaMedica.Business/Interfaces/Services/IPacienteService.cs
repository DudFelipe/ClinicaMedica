﻿using ClinicaMedica.Business.Models;
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
        public Task Remover(Guid id);
        public void Dispose();
    }
}