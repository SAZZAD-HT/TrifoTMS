using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PoliceCaseDTO
    {
        public virtual List<CaseDTO> Cases { get; set; }
        public PoliceCaseDTO()
        {
            Cases = new List<CaseDTO>();
        }
    }
}
