using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AccountManager.Models
{
    public class Receita
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int id { get; set; }
        [Column("DESCRICAO")]
        public string descricao { get; set; }
        [Column("VALOR")]
        public decimal valor { get; set; }
        [Column("DATA")]
        public DateTime data { get; set; }
        [Column("RECEBIDO")]
        public bool pago { get; set; }
    }
}
