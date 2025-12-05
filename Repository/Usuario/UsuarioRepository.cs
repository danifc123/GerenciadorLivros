using EFModels.DBConfig;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UsuarioRepository
{
    /* Outra forma de fazer porem resumido
     *  
     *public class UsuarioRepository(GerenciadorLivrariaDb context)
      {
      private readonly GerenciadorLivrariaDb _context = context;
      }
     
     */
    public class UsuarioRepository
    {
        private readonly GerenciadorLivrariaDb _context;

        public UsuarioRepository(GerenciadorLivrariaDb context)
        {
            _context = context;
        }

        public async Task<Usuario> GetByIdUser(int id) 
        {
            /*forma reduzida 
            return await _context.Usuarios.FindAsync(id);
            */
            var usuarioBanco = await _context.Usuarios.FindAsync(id);
            
            return usuarioBanco;
        }

        public async Task<Usuario> AddUserAsync(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();

            return usuario;
        }
        public async Task<Usuario> PostUserAsync(int id, Usuario usuario) 
        {
            var usuarioBanco = await _context.Usuarios.FindAsync(id);

            usuarioBanco.Nome = usuario.Nome;
            usuarioBanco.Email = usuario.Email;
            usuarioBanco.Senha = usuario.Senha;

            _context.Usuarios.Update(usuarioBanco);
            await _context.SaveChangesAsync();

            return usuarioBanco;
        }
        public async Task<bool> DesativarUserAsync(int id) 
        {
            var usuarioBanco = await _context.Usuarios.FindAsync(id);
            if (usuarioBanco == null) 
            {
                return false;
            }
            usuarioBanco.Ativado = false;

            _context.Usuarios.Update(usuarioBanco);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> AtivarUsuarioAsync(int id)
        {
            var usuarioBanco = await _context.Usuarios.FindAsync(id);
            if (usuarioBanco == null)
            {
                return false;
            }
            usuarioBanco.Ativado = true;

            _context.Usuarios.Update(usuarioBanco);
            await _context.SaveChangesAsync();

            return true;
        }

    }
}
