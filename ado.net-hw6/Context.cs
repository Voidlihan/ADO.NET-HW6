using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ado.net_hw6
{
    
    public class Context : DbContext
    {        
        public Context()
        {
            Database.EnsureCreated();
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Lib> Libs { get; set; }
        public DbSet<User> dbusers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=A-305-03;Database=Library;Trusted_Connection=true;");
        }
    }
}
