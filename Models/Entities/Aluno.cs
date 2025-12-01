using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    internal class Aluno
    {
        #region Id
        public int Id { get; set; }
        public int UsiarioId { get; set; }
        #endregion
        #region Propriedades
        [Required]
        public required string Matricula { get; set; }
        public string? Sala { get; set; }
        #endregion
    }
}
