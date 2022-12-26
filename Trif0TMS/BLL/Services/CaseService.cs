using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CaseService
    {
        public static CaseDTO Add(CaseDTO c)
        {
            var config = MapServices.Mapping<CaseDTO, Case>();
            var mapper = new Mapper(config);
            var data = mapper.Map<Case>(c);
            var repo = DataAccessFactory.CaseDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<CaseDTO>(repo);
            }
            return null;
        }

        public static List<CaseDTO> Get()
        {
            var cfg = MapServices.OneTimeMapping<Case, CaseDTO>();
            var mapper = new Mapper(cfg);
            var access = DataAccessFactory.CaseDataAccess().Get();
            return mapper.Map<List<CaseDTO>>(access);
        }

        public static CaseDTO Get(int id)
        {
            var config = MapServices.OneTimeMapping<Case, CaseDTO>();
            var mapper = new Mapper(config);
            var data = DataAccessFactory.CaseDataAccess().Get(id);
            return mapper.Map<CaseDTO>(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.CaseDataAccess().Delete(id);
            return data;
        }

        public static CaseDTO Update(CaseDTO caseDTO)
        {
            var config = MapServices.Mapping<Case, CaseDTO>();
            var mapper = new Mapper(config);
            var ca = mapper.Map<Case>(caseDTO);
            var data = DataAccessFactory.CaseDataAccess().Update(ca);
            if (data != null)
            {
                return mapper.Map<CaseDTO>(data);
            }
            return null;
        }
    }
}