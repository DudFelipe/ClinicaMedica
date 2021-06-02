using AutoMapper;
using ClinicaMedica.App.ViewModels;
using ClinicaMedica.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaMedica.App.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Especialidade, EspecialidadeViewModel>().ReverseMap();
            CreateMap<Medico, MedicoViewModel>().ReverseMap();
            CreateMap<Paciente, PacienteViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
        }
    }
}
