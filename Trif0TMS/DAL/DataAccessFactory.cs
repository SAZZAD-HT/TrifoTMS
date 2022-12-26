using DAL.EF.Models;
using DAL.Interface;
using DAL.Repo;
using DAL.Repos;
using System;
using System.Collections;
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

        public static IRepo<Notice, int, Notice> NoticeDataAccess()
        {
            return new NoticeRepo();
        }

        public static IRepo<Police, int, Police> PoliceDataAccess()
        {
            return new PoliceRepo();
        }
        public static IAuth<Police, int> PoliceAuthDataAccess()
        {
            return new PoliceRepo();
        }

        public static AuthC<Police, string> PoliceAuthCheckerDataAccess()
        {
            return new PoliceRepo();
        }

        public static IRepo<Case, int, Case> CaseDataAccess()
        {
            return new CaseRepo();
        }

        public static IRepo<Fare, int, Fare> FareDataAccess() 
        {
            return new FareRepo();
        }

        public static IRepo<Trip, int, Trip> TripDataAccess()
        {
            return new TripRepo();
        }
    }
}
