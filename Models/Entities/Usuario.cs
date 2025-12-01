using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    internal class Usuario
    {
        #region Id
        public int Id { get; set; }
        #endregion
        #region Propriedades
        [Required]
        public required string Email { get; set; }
        [Required]
        public required string Nome { get; set; }
        [Required]
        public required string Senha { get; set; }
        #endregion
    }
}
