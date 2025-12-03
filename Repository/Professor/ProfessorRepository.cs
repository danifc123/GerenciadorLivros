using EFModels.DBConfig;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ProfessorRepository
{
    public class ProfessorRepository
    {
        private readonly GerenciadorLivrariaDb _context;

        public ProfessorRepository(GerenciadorLivrariaDb context) 
        {
            _context = context;
        }
        

    }
}
