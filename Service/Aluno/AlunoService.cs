using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
using Repository.Alunos;

namespace Service.AlunoService
{
    public class AlunoService
    {
        private readonly AlunoRepository _repository;

        public AlunoService(AlunoRepository repository) 
        {
            _repository = repository;
        }
        public async Task<Aluno> GetById(int id)
        {
            return await _repository.GetAlunoByIdAsync(id);
        }
        public async Task<Aluno> AddAluno(Aluno aluno) 
        {
            return await _repository.AddAlunoAsync(aluno);
        }
        public async Task<Aluno> UpdateAluno(int id, Aluno aluno) 
        {
            return await _repository.PostAlunoAsync(id, aluno);
        }
        public async Task<Aluno> DeleteAluno(int id) 
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
