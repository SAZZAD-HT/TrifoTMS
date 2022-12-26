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
    public class TripService
    {
        public static TripDTO Add(TripDTO t)
        {
            var config = MapServices.Mapping<TripDTO, Trip>();
            var mapper = new Mapper(config);
            var data = mapper.Map<Trip>(t);
            var repo = DataAccessFactory.TripDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<TripDTO>(repo);
            }
            return null;
        }

        public static List<TripDTO> Get()
        {
            var cfg = MapServices.OneTimeMapping<Trip, TripDTO>();
            var mapper = new Mapper(cfg);
            var access = DataAccessFactory.TripDataAccess().Get();
            return mapper.Map<List<TripDTO>>(access);
        }

        public static TripDTO Get(int id)
        {
            var config = MapServices.OneTimeMapping<Trip, TripDTO>();
            var mapper = new Mapper(config);
            var data = DataAccessFactory.TripDataAccess().Get(id);
            return mapper.Map<TripDTO>(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.TripDataAccess().Delete(id);
            return data;
        }

        public static TripDTO Update(TripDTO TripDTO)
        {
            var config = MapServices.Mapping<Trip, TripDTO>();
            var mapper = new Mapper(config);
            var ca = mapper.Map<Trip>(TripDTO);
            var data = DataAccessFactory.TripDataAccess().Update(ca);
            if (data != null)
            {
                return mapper.Map<TripDTO>(data);
            }
            return null;
        }
    }
}
