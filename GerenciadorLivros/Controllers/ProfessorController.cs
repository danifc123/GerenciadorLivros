using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Service.AluguelService;
using Service.ProfessorService;
using System.Security.Cryptography.X509Certificates;

namespace GerenciadorLivros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly ProfessorService _professorservice;

        public ProfessorController(ProfessorService professor)
        {
            _professorservice = professor;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Professor>> GetProfessor(int id)
        {
            try
            {
                var professor = await _professorservice.GetProfessorById(id);

                if (professor == null) return NotFound("Professor não encontrado.");
                return Ok(professor);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }
        }
        [HttpPost]
        public async Task<ActionResult<Professor>> CreateProfessor(Professor professor)
        {
            try
            {
                var professorBanco = await _professorservice.AddProfessor(professor);
                if (professorBanco == null) return BadRequest("Não foi possível criar o professor.");
                return Ok(professorBanco);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }
        }
        [HttpPut]
        public async Task<ActionResult<Professor>> AtualizaProfessor(int id, Professor professor) 
        {
            try
            {
                var professorBanco = await _professorservice.AtualizaProfessor(id, professor);
                if (professor == null) return NotFound("Professor não encontrado.");
                return Ok(professorBanco);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Professor>> DeleteProfessor(int id) 
        {
            try 
            {
                var professorBanco = await _professorservice.DeleteProfessor(id);
                if (professorBanco == null) return NotFound("Professor não encontrado.");
                return Ok("Professor deletado com sucesso.");
            }
            catch (Exception ex) 
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }
        }

    }
}