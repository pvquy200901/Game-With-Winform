using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace test.DataModel
{
    public partial class DataProfile : DbContext
    {
        public DataProfile()
            : base("name=DataProfile")
        {
        }

        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>()
                .Property(e => e.Name)
                .IsFixedLength();
        }
    }
}
