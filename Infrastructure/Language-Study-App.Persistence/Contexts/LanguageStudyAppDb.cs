using Language_Study_App.Domain.Entities;
using Language_Study_App.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Study_App.Persistence.Contexts
{
    public class LanguageStudyAppDb:DbContext
    {
        public LanguageStudyAppDb(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PV> PVs { get; set; }
        public DbSet<Translate> Translates { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<AllEntitie> AllEntities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.ConnectionString);
        }
    }
}
