using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace EFModels.DBConfig
{
    public class GerenciadorLivrariaDb : DbContext
    {
        #region Construtor
        public GerenciadorLivrariaDb(DbContextOptions<GerenciadorLivrariaDb> options) : base(options) 
        { 
        }
        #endregion
        #region DbSets
        // Defina seus DbSets aqui
        public DbSet<Aluguel> Alugueis { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        #endregion
    }
}
