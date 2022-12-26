using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Case
    {
        [Key]
        public int C_Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Posting { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public string Fine { get; set; }

        [ForeignKey("Police")]
        public int ID { get; set; }
        public virtual Police Police { get; set; }
    }
}
