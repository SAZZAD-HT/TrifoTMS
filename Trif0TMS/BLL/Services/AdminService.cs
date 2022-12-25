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
    public class AdminService
    {
        public static AdminDTO Add(AdminDTO adminDTO)
        {
            var config = MapServices.Mapping<AdminDTO, Admin>();
            var mapper = new Mapper(config);
            var data = mapper.Map<Admin>(adminDTO);
            var repo = DataAccessFactory.AdminDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<AdminDTO>(repo);
            }
            return null;
        }

        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.AdminDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<AdminDTO>>(data);
        }

        public static AdminDTO Get(int id)
        {
            var data = DataAccessFactory.AdminDataAccess().Get(id);
            var config = MapServices.OneTimeMapping<Admin, AdminDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<AdminDTO>(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.AdminDataAccess().Delete(id);
            return data;

        }

        public static AdminDTO Update(AdminDTO adminDTO)
        {
            var config = MapServices.Mapping<Admin, AdminDTO>();
            var mapper = new Mapper(config);
            var admin = mapper.Map<Admin>(adminDTO);
            var data = DataAccessFactory.AdminDataAccess().Update(admin);
            if (data != null)
            {
                return mapper.Map<AdminDTO>(data);
            }

            return null;

        }

        public static AdminDTO GetChecker(string name)
        {
            var data = DataAccessFactory.AdminAuthCheckerDataAccess().GetChecker(name);
            var config = MapServices.OneTimeMapping<Admin, AdminDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<AdminDTO>(data);
        }
    }
}
