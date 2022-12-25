using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRepo<CLASS, ID, RETURNTYPE>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        RETURNTYPE Add(CLASS obj);
        bool Delete(ID id);
        RETURNTYPE Update(CLASS obj);
    }
}
