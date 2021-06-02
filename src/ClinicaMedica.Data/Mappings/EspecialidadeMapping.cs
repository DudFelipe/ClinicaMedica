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
    public class EspecialidadeMapping : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.HasMany(e => e.Medicos)
                .WithOne(m => m.Especialidade)
                .HasForeignKey(m => m.EspecialidadeId);

            builder.ToTable("Especialidades");
        }
    }
}
