using CrudMVC.Web.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CrudMVC.Web.Data
{
    public class CrudMVCContext : DbContext
    {
        public CrudMVCContext(): base("CrudMVC_Desenv")
        {

        }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}