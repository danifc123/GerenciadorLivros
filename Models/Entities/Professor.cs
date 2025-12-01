using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Professor
    {
        #region Id
        public int Id { get; set; }
        #endregion
        #region Propriedades
        public int UsiarioId { get; set; }
        public required string Materia { get; set; }
        public required string CPF { get; set; }
        #endregion
    }
}
