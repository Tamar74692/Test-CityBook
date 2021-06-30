using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace DAL
{
    public class FormCBContext : DbContext
    {
        public FormCBContext() : base("name=FormCB")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<FormCBContext>());
        }
        

        public DbSet<Person> person { get; set; }
        public DbSet<Child> child { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().Property(p => p.Identity).IsRequired();
            modelBuilder.Entity<Child>().Property(p => p.Identity).IsRequired();
        }

    }
}
