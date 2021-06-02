using ClinicaMedica.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Data.Mappings
{
    //Mapeando como deve ser a entidade no banco de dados
    public class MedicoMapping : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(m => m.Id); //Definindo o campo chave (Primary Key)

            //Definindo que a propriedade Nome deve ser obrigatória e do tipo varchar(200)
            builder.Property(m => m.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(m => m.CRM)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(m => m.DataNascimento)
                .IsRequired();

            //Definindo o relacionamento. 1 Médico pode ter N Especialidades
            // 1 : N => Medico : Especialidades
            //builder.HasOne(m => m.Especialidade) //Muitas especialidades
            //    .WithMany(e => e.Medicos); //Definindo chave estrangeira do médico na especialidade

            //Definindo o nome da tabela que deve ser criada
            builder.ToTable("Medicos");

        }
    }
}
