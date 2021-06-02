using System;

namespace ClinicaMedica.Business.Models
{
    public class Paciente : Entity
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnumSexo Sexo { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }
    }
}
