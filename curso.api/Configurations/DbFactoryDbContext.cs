using curso.api.Infraestruture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace curso.api.Configurations
{
    public class DbFactoryDbContext : IDesignTimeDbContextFactory<CursoDbContext>
    {
        public CursoDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            optionBuilder.UseSqlServer("Server=localhost;Database=CURSO;user=sa;password=kkk;Integrated Security=true;");
            CursoDbContext context = new CursoDbContext(optionBuilder.Options);
            return context;
        }
    }
}
