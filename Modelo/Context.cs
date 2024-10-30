using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Context:DbContext
    {
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Drogueria> Droguerias { get; set; }
        public DbSet<Monodroga> Monodrogas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Farmacia;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0");

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Medicamento>().HasOne(m => m.Monodroga); // relación de una Monodroga en un Medicamento
            model.Entity<Medicamento>().HasMany(m => m.Droguerias).WithMany(); // relación de muchas Droguerías en un Medicamento
        }
    }
}
