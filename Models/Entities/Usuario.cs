using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Usuario
    {
        #region Id
        public int Id { get; set; }
        #endregion
        #region Propriedades

        public bool Ativado { get; set; } = true;

        [Required]
        public required string Email { get; set; }
        [Required]
        public required string Nome { get; set; }
        [Required]
        public required string Senha { get; set; }
        #endregion
    }
}
