using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CaseDTO
    {
        public int C_Id { get; set; }
        public string Type { get; set; }
        public string Posting { get; set; }
        public DateTime Time { get; set; }
        public string Fine { get; set; }
        public int ID { get; set; }
    }
}
