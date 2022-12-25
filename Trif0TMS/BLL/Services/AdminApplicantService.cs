using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminApplicantService
    {
        public static AdminApplicantDTO Add(AdminApplicantDTO adminapplicantDTO)
        {
            var config = MapServices.Mapping<AdminApplicantDTO, AdminApplicant>();
            var mapper = new Mapper(config);
            var data = mapper.Map<AdminApplicant>(adminapplicantDTO);
            var repo = DataAccessFactory.ApplicantDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<AdminApplicantDTO>(repo);
            }
            return null;
        }

        public static List<AdminApplicantDTO> Get()
        {
            var data = DataAccessFactory.ApplicantDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AdminApplicant, AdminApplicantDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<AdminApplicantDTO>>(data);
        }

        public static AdminApplicantDTO Get(int id)
        {
            var data = DataAccessFactory.ApplicantDataAccess().Get(id);
            var config = MapServices.OneTimeMapping<AdminApplicant, AdminApplicantDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<AdminApplicantDTO>(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.ApplicantDataAccess().Delete(id);
            return data;
        }

        public static AdminApplicantDTO Update(AdminApplicantDTO adminapplicantDTO)
        {
            var config = MapServices.Mapping<AdminApplicant, AdminApplicantDTO>();
            var mapper = new Mapper(config);
            var admin = mapper.Map<AdminApplicant>(adminapplicantDTO);
            var data = DataAccessFactory.ApplicantDataAccess().Update(admin);
            if (data != null)
            {
                return mapper.Map<AdminApplicantDTO>(data);
            }
            return null;
        }

        public static AdminApplicantDTO GetChecker(string name)
        {
            var data = DataAccessFactory.AdminAuthCheckerDataAccess().GetChecker(name);
            var config = MapServices.OneTimeMapping<AdminApplicant, AdminApplicantDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<AdminApplicantDTO>(data);
        }
    }
}