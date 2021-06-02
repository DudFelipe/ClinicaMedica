using ClinicaMedica.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaMedica.App.ViewModels
{
    public class MedicoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [DisplayName("Especialidade")]
        public Guid EspecialidadeId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres!", MinimumLength = 3)]
        public string Nome { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string CRM { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        public EspecialidadeViewModel Especialidade { get; set; }

        [NotMapped]
        public IEnumerable<EspecialidadeViewModel> Especialidades { get; set; }
    }
}
