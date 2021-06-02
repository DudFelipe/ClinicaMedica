using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ClinicaMedica.App.ViewModels;

namespace ClinicaMedica.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ClinicaMedica.App.ViewModels.MedicoViewModel> MedicoViewModel { get; set; }
    }
}
