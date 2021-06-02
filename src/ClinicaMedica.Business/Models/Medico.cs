using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Business.Models
{
    public class Medico : Entity
    {
        public Guid EspecialidadeId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CRM { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public Especialidade Especialidade { get; set; }
    }
}
