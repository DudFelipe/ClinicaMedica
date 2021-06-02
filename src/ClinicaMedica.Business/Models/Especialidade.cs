using System;
using System.Collections.Generic;

namespace ClinicaMedica.Business.Models
{
    public class Especialidade : Entity
    {
        public string Descricao { get; set; }

        /* EF Relations */
        public IEnumerable<Medico> Medicos { get; set; }
    }
}
