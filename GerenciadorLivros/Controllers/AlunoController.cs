using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Service.AlunoService;
using System.Linq.Expressions;

namespace GerenciadorLivros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController: ControllerBase
    {
        private readonly AlunoService _service;

        public AlunoController(AlunoService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Aluno>> GetAlunoById(int id)
        {
            try
            {
                var alunoBanco = await _service.GetById(id);
                return Ok(alunoBanco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<ActionResult<Aluno>> PutAluno(int id, Aluno aluno) 
        {
            try
            {
                var alunoBanco = await _service.UpdateAluno(id, aluno);
                return Ok(alunoBanco);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpPost]
        public async Task<ActionResult<Aluno>> PostAluno(Aluno aluno)
        {
            try
            {
                var alunoBanco = await _service.AddAluno(aluno);

                return Ok(alunoBanco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Aluno>> DeleteAluno(int id) 
        {
            try 
            {
                var alunoBanco = await _service.DeleteAluno(id);
                return Ok(alunoBanco);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
