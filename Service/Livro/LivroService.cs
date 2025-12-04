 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
using Repository.Livros;


namespace Service.LivroService
{
    public class LivroService
    {
        private readonly LivroRepository _repository;

        public LivroService(LivroRepository repository)
        {
            _repository = repository;
        }

        public async Task<Livro> GetById(int id) 
        {
            return await _repository.GetLivroAsync(id);
        }
        public async Task<Livro> AdicionarLivro(Livro livro) 
        {
            return await _repository.AddLivroAsync(livro);
        }
        public async Task<Livro> AtualizarLivro(int id, Livro livro)
        {
            return await _repository.PostLivroAsync(id, livro);
        }
        public async Task<Livro> DeletarLivro(int id) 
        {
            return await _repository.DeleteLivroAsync(id);
        }
    }
}
