using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFModels.DBConfig;
using Models.Entities;

namespace Repository.AluguelRepository
{
    public class AluguelRepository
    {
        #region Constructor
        private readonly GerenciadorLivrariaDb _context;
        public AluguelRepository(GerenciadorLivrariaDb context)
        {
            _context = context;
        }
        #endregion
        #region Methods
        public async Task<Aluguel> GetByIdAsync(int id)
        {
            var aluguelBanco = await _context.Alugueis.FindAsync(id);
            
            if (aluguelBanco == null)
                return null;

            return aluguelBanco;
        }
        public async Task<Aluguel> AddAsync(Aluguel aluguel)
        {
            await _context.Alugueis.AddAsync(aluguel);
            await  _context.SaveChangesAsync();
            return aluguel;
        }
        public async Task<Aluguel> PostAsync(int id, Aluguel aluguel) 
        {
            var aluguelBanco = await _context.Alugueis.FindAsync(id);

            
            aluguelBanco.AlunoId = aluguel.AlunoId;
            aluguelBanco.LivroId = aluguel.LivroId;
            aluguelBanco.ProfessorId = aluguel.ProfessorId;
            aluguelBanco.DataInicio = aluguel.DataInicio;
            aluguelBanco.DataDevolucao = aluguel.DataDevolucao;

            _context.Alugueis.Update(aluguelBanco);
            await _context.SaveChangesAsync();

            return aluguelBanco;
        }
        public async Task<Aluguel> DeleteAsync(int id)
        {
            var aluguelBanco = _context.Alugueis.Find(id);

            _context.Alugueis.Remove(aluguelBanco);
            await _context.SaveChangesAsync();

            return aluguelBanco;
        }
        #endregion


    }
}
