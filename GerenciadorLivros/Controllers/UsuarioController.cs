using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Service.UsuarioService;

namespace GerenciadorLivros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;
        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GeByIdUsuario(int id)
        {
            try 
            {
                var usuarioBanco = await _usuarioService.GetUsuario(id);
                return Ok(usuarioBanco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult<Usuario>> AddUsuario(Usuario usuario)
        {
            try
            { 
                var usuarioBanco = await _usuarioService.AddUsuario(usuario);
                return Ok(usuarioBanco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Usuario>> UpdateUsuario(int id, Usuario usuario)
        {
            try
            {
                var usuarioBanco = await _usuarioService.UpdateUsuario(id, usuario);
                return Ok(usuarioBanco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPatch("desativar/{id}")]
        public async Task<ActionResult<bool>> DesativarUsuario(int id)
        {
            try
            {
                var resultado = await _usuarioService.DesativarUsuario(id);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPatch("ativar/{id}")]
        public async Task<ActionResult<bool>> AtivarUsuario(int id)
        {
            try
            {
                var resultado = await _usuarioService.AtivarUsuario(id);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
