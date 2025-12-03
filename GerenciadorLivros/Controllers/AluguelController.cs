using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Service.AluguelService;

namespace GerenciadorLivros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AluguelController : ControllerBase
    {
        #region Constructor
        private readonly AluguelService _aluguelService;

        public AluguelController(AluguelService aluguelService)
        {
            _aluguelService = aluguelService;
        }
        #endregion
        #region Controllers
        [HttpPost]
        public async Task<ActionResult<Aluguel>> PostAluguel(Aluguel aluguel)
        {
            try
            {
                var createdAluguel = await _aluguelService.Add(aluguel);
                if (createdAluguel == null) return BadRequest("Não foi possível realizar o aluguel.");
                return Ok(createdAluguel);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Aluguel>> GetAluguelById(int id)
        {
            try
            {
                var aluguel = await _aluguelService.GetById(id);
                if (aluguel == null) return NotFound("Aluguel não encontrado.");
                return Ok(aluguel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }

        }

        [HttpPut]
        public async Task<ActionResult<Aluguel>> PutAluguel(int id, Aluguel aluguel)
        {
            try
            {
                var updateAluguel = await _aluguelService.Post(id, aluguel);
                return Ok(updateAluguel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Aluguel>> DeleteAluguel(int id) 
        {
            try 
            {
                var deleteAluguel = await _aluguelService.Delete(id);
                return Ok(deleteAluguel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }
        }
        #endregion
    }
}
