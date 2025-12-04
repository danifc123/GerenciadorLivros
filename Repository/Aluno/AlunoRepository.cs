using EFModels.DBConfig;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Alunos
{
    public class AlunoRepository
    {

        #region Attributes
        private readonly GerenciadorLivrariaDb _context;

        #endregion
        #region Constructor
        public AlunoRepository(GerenciadorLivrariaDb context) 
        {
            _context = context;
        }
        #endregion
        public async Task<Aluno> GetAlunoByIdAsync(int id) 
        {
            var alunoById = await _context.Alunos.FindAsync(id);

            return alunoById;
        }
        public async Task<Aluno> AddAlunoAsync(Aluno aluno) 
        {
            await _context.Alunos.AddAsync(aluno);
            await _context.SaveChangesAsync();
            return aluno;
        }
        public async Task<Aluno> PostAlunoAsync(int id, Aluno aluno) 
        {
            var alunoBanco = await _context.Alunos.FindAsync(id);

            alunoBanco.UsiarioId = aluno.UsiarioId;
            alunoBanco.Matricula = aluno.Matricula;
            alunoBanco.Sala = aluno.Sala;

            _context.Alunos.Update(alunoBanco);
            await _context.SaveChangesAsync();

            return alunoBanco;
        }
        public async Task<Aluno> DeleteAsync(int id) 
        {
            var alunoDelete = _context.Alunos.Find(id);
            _context.Alunos.Remove(alunoDelete);
            await _context.SaveChangesAsync();
            
            return alunoDelete;
        }
    }
}
