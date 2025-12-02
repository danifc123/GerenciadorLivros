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
        public async Task<ActionResult<Aluguel>> Post(Aluguel aluguel)
        {
            try 
            {
                var createdAluguel = await _aluguelService.Add(aluguel);
                if(createdAluguel == null) return BadRequest("Não foi possível realizar o aluguel.");
                return Ok(createdAluguel);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        
        #endregion

    }
}
