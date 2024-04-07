using Microsoft.EntityFrameworkCore;
using StudentGuide.Models;

namespace GestaoAcademica.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
    }
}