using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace EFModels.DBConfig
{
    internal class GerenciadorLivrariaDb : DbContext
    {
        #region Construtor
        public GerenciadorLivrariaDb(DbContextOptions<GerenciadorLivrariaDb> options) : base(options) 
        { 
        }
        #endregion
        #region DbSets
        // Defina seus DbSets aqui
        public DbSet<Aluno> Alunos { get; set; }
        #endregion
    }
}
