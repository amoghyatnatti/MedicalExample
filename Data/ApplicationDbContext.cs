using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalExample.Models;

namespace MedicalExample.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MedicalExample.Models.Diagnosis> Diagnosis { get; set; }
        public DbSet<MedicalExample.Models.Patient> Patient { get; set; }
        public DbSet<MedicalExample.Models.Provider> Provider { get; set; }
    }
}
