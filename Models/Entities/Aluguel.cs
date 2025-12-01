using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    internal class Aluguel
    {
        #region Id
        public int Id { get; set; }
        [Required]
        public required int AlunoId { get; set; }
        [Required]
        public required int LivroId { get; set; }
        [Required]
        public required int ProfessorId { get; set; }
        #endregion
        #region Datas
        [Required]
        public required DateTime DataInicio { get; set; }
        [Required]
        public required DateTime DataDevolucao { get; set; }
        #endregion
    }
}
