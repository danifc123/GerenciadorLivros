using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Service.LivroService;

namespace GerenciadorLivros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly LivroService _livroService;

        public LivroController(LivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Livro>> GetLivroById(int id)
        {
            try
            {
                var livroBanco = await _livroService.GetById(id);
                return Ok(livroBanco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult<Livro>> AdicionarLivro(Livro livro)
        {
            try
            {
                var livroBanco = await _livroService.AdicionarLivro(livro);
                return Ok(livroBanco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Livro>> AtualizarLivro(int id, Livro livro) 
        {
            try 
            {
                var livroBanco = await _livroService.AtualizarLivro(id, livro);
                return Ok(livroBanco);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Livro>> DeleteLivro(int id)
        {
            try 
            {
                var livroBanco = await _livroService.DeletarLivro(id);
                return Ok(livroBanco);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
