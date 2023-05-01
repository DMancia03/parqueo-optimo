using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_parqueo.Modelos
{
    [Table("CLIENTE")]
    public class Cliente
    {
        [Key]
        [Column("DUI")]
        [MaxLength(10)]
        public string Dui { get; set; }

        [Column("NOMBRE")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Column("APELLIDO")]
        [MaxLength(50)]
        public string Apellido { get; set; }
    }
}
