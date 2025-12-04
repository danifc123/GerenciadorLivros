using Models.Entities;
using Repository.ProfessorRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ProfessorService
{
    public class ProfessorService
    {
        private readonly ProfessorRepository _repository;

        public ProfessorService(ProfessorRepository repository) 
        {
            _repository = repository;
        }
        public async Task<Professor> GetProfessorById(int id) 
        {
            return await _repository.GetByIdProfessor(id);
        }
        public async Task<Professor> AddProfessor(Professor professor) 
        {
            return await _repository.CreateProfessor(professor);
        }
        public async Task<Professor> AtualizaProfessor(int id, Professor professor) 
        {
            return await _repository.UpdateProfessor(id, professor);
        }
        public async Task<Professor> DeleteProfessor(int id) 
        {
            return await _repository.DeleteProfessor(id);
        }
    }
}
