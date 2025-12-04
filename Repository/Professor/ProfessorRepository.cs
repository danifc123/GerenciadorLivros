using EFModels.DBConfig;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ProfessorRepository
{
    public class ProfessorRepository
    {
        private readonly GerenciadorLivrariaDb _context;

        public ProfessorRepository(GerenciadorLivrariaDb context)
        {
            _context = context;
        }

        public async Task<Professor> GetByIdProfessor(int id)
        {
            var professor = _context.Professores.Find(id);
            return professor;
        }

        public async Task<Professor> CreateProfessor(Professor professor)
        {
            await _context.Professores.AddAsync(professor);
            await _context.SaveChangesAsync();

            return professor;
        }

        public async Task<Professor> UpdateProfessor(int id, Professor professor)
        {
            var professorBanco = await _context.Professores.FindAsync(id);

            professorBanco.Materia = professor.Materia;
            professorBanco.CPF = professor.CPF;
            professor.UsiarioId = professor.UsiarioId;

            _context.Professores.Update(professorBanco);
            await _context.SaveChangesAsync();

            return professorBanco;
        }

        public async Task<Professor> DeleteProfessor(int id) 
        {
            var professorbanco = await _context.Professores.FindAsync(id);

            _context.Professores.Remove(professorbanco);
            await _context.SaveChangesAsync();

            return professorbanco;
        }
    }
}
