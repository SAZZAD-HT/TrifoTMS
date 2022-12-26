using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PoliceService
    {
        public static PoliceDTO Add(PoliceDTO p)
        {
            var config = MapServices.Mapping<PoliceDTO, Police>();
            var mapper = new Mapper(config);
            var data = mapper.Map<Police>(p);
            var repo = DataAccessFactory.PoliceDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<PoliceDTO>(repo);
            }
            return null;
        }

        public static List<PoliceDTO> Get()
        {           
            var config = MapServices.OneTimeMapping<Police, PoliceDTO>();
            var mapper = new Mapper(config);
            var data = DataAccessFactory.PoliceDataAccess().Get();
            return mapper.Map<List<PoliceDTO>>(data);
        }

        public static PoliceDTO Get(int id)
        {          
            var config = MapServices.OneTimeMapping<Police, PoliceDTO>();
            var mapper = new Mapper(config);
            var data = DataAccessFactory.PoliceDataAccess().Get(id);
            return mapper.Map<PoliceDTO>(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.PoliceDataAccess().Delete(id);
            return data;
        }

        public static PoliceDTO Update(PoliceDTO policeDTO)
        {
            var config = MapServices.Mapping<Police, PoliceDTO>();
            var mapper = new Mapper(config);
            var staffs = mapper.Map<Police>(policeDTO);
            var data = DataAccessFactory.PoliceDataAccess().Update(staffs);
            if (data != null)
            {
                return mapper.Map<PoliceDTO>(data);
            }
            return null;
        }

        public static PoliceDTO GetChecker(string name)
        {
            var data = DataAccessFactory.PoliceAuthCheckerDataAccess().GetChecker(name);
            var config = MapServices.OneTimeMapping<Police, PoliceDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<PoliceDTO>(data);
        }

        public static PoliceCaseDTO Getwithcase(int id)
        {
            var data = DataAccessFactory.PoliceDataAccess().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Police, PoliceCaseDTO>();
                c.CreateMap<Case, CaseDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<PoliceCaseDTO>(data);
        }
    }
}
