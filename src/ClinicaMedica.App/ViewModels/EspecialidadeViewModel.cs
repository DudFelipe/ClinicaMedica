using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaMedica.App.ViewModels
{
    public class EspecialidadeViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Descricao { get; set; }

        //[HiddenInput]
        //public Guid MedicoId { get; set; }
    }
}
