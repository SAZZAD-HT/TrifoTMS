using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Trip
    {
        [Key]
        [Required]
        public int session { get; set; }

        [Required]
        public string Start { get; set; }
    }
}
