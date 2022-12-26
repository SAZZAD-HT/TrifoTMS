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
    public class FareService
    {
        static int start1;
        static int end1;
        public static List<FareDTO> Get()
        {
            var data = DataAccessFactory.FareDataAccess().Get();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Fare, FareDTO>();

            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<FareDTO>>(data);

            //public static StartEnd Add(StartEnd div)
            //{





            //    return null;
            //}
        }
    }
}
