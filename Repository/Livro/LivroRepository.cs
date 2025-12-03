using EFModels.DBConfig;
using Microsoft.AspNetCore.Http.HttpResults;
using Models.Entities;


namespace Repository.Livros
{
    internal class LivroRepository
    {
        private readonly GerenciadorLivrariaDb _context;

        public LivroRepository(GerenciadorLivrariaDb context) 
        {
            _context = context;
        }

        public async Task<Livro> GetLivroAsync(int id) 
        {
            var getLivro = await _context.Livros.FindAsync(id);

            return getLivro!;
        }
        public async Task<Livro> AddLivro(Livro livro) 
        {
            await _context.Livros.AddAsync(livro);
            await _context.SaveChangesAsync();
            return livro;
        }
        public async Task<Livro> PostLivroAsync(int id, Livro livro)
        {
            var updateLivro = await _context.Livros.FindAsync(id);

            updateLivro.Titulo = livro.Titulo;
            updateLivro.Autor = livro.Autor;
            updateLivro.Editora = livro.Editora;
            updateLivro.AnoPublicacao = livro.AnoPublicacao;

            _context.Livros.Update(updateLivro);
            await _context.SaveChangesAsync();

            return updateLivro;
        }
        public async Task<Livro> DeleteLivroAsync(int id)
        {
            var deleteLivro = _context.Livros.Find(id);
            
            _context.Remove(deleteLivro);
            await _context.SaveChangesAsync();

            return deleteLivro!;
        }
    }
}
