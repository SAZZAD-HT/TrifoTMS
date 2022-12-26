using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Fare
    {
        [Key]
        public int Route_Id { get; set; }

        [Required]
        public int Distance { get; set; }

        [Required]
        public int Fare1 { get; set; }
    }
}