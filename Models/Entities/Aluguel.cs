using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    internal class Aluguel
    {
        #region Id
        public int Id { get; set; }
        public required int AlunoId { get; set; }
        public required int LivroId { get; set; }
        public required int ProfessorId { get; set; }
        #endregion
        #region Datas
        public required DateTime DataInicio { get; set; }
        public required DateTime DataDevolucao { get; set; }
        #endregion
    }
}
