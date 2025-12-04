using Models.Entities;
using Repository.UsuarioRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.UsuarioService
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _repository;

        public UsuarioService(UsuarioRepository repositorio) 
        {
            _repository = repositorio;
        }
        public async Task<Usuario> GetUsuario(int id) 
        {
            return await _repository.GetByIdUser(id);
        }
        public async Task<Usuario> AddUsuario(Usuario usuario) 
        {
            return await _repository.AddUserAsync(usuario);
        }
        public async Task<Usuario> UpdateUsuario(int id,Usuario usuario) 
        {
            return await _repository.PostUserAsync(id,usuario);
        }
        public async Task<bool> DesativarUsuario(int id) 
        {
            return await _repository.DesativarUserAsync(id);
        }
        public async Task<bool> AtivarUsuario(int id)
        {
            return await _repository.AtivarUsuarioAsync(id);
        }
            
    }
}
