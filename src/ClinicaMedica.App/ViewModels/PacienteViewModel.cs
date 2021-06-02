using ClinicaMedica.Business.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClinicaMedica.App.ViewModels
{
    public class PacienteViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres!", MinimumLength = 3)]
        public string Nome { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        public EnumSexo Sexo { get; set; }
        public EnderecoViewModel Endereco { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }
    }
}
