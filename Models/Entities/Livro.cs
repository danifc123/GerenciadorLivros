using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Livro
    {
        #region Id
        public int Id { get; set; }
        [Required]
        public required string Titulo { get; set; }
        [Required]
        public required string Autor { get; set; }
        public  string? Editora { get; set; }
        public  string? AnoPublicacao { get; set; }
        #endregion
    }
}
