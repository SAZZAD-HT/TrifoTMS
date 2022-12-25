using DAL.EF.Models;
using DAL.Interface;
using DAL.Repo;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Admin, int, Admin> AdminDataAccess()
        {
            return new AdminRepo();
        }
        public static IAuth<Admin, int> AdminAuthDataAccess()
        {
            return new AdminRepo();
        }

        public static AuthC<Admin, string> AdminAuthCheckerDataAccess()
        {
            return new AdminRepo();
        }

        public static IRepo<AdminApplicant, int, AdminApplicant> ApplicantDataAccess()
        {
            return new AdminApplicantRepo();
        }

        public static IRepo<Token, string, Token> TokenDataAccess()
        {
            return new TokenRepo();
        }
    }
}
