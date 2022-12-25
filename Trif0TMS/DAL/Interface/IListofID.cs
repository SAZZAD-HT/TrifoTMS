using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IListofID<CLASS,RET>
    {
        List<CLASS> GetListOfId(int id);
        CLASS GetCategory(string category);
    }
}
