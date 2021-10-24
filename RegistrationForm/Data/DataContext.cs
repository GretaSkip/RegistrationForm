using Microsoft.EntityFrameworkCore;
using RegistrationForm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationForm.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }

        public DbSet<Registration> Registrations { get; set; }
    }
}
