using Microsoft.EntityFrameworkCore;
using Note.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Note.DAL.DataContext
{
    public class NoteDbContext : DbContext
    {
        public DbSet<Notice> Notices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=NoteDb;User Id=sa;Password=phr8611!;");
        }
    }
}
