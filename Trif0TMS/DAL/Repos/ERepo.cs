using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ERepo
    {
        protected TMSEntities db;
        internal ERepo()
        {
            db = new TMSEntities();
        }
    }
}
