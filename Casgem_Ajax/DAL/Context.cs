using Microsoft.EntityFrameworkCore;

namespace Casgem_Ajax.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-FCHRJ42\SQLEXPRESS;initial Catalog=CasgemAjaxDb; integrated security=true;trust server certificate=true;");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
