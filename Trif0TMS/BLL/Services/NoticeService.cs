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
    public class NoticeService
    {
        public static NoticeDTO Add(NoticeDTO noticeDTO)
        {
            var config = MapServices.Mapping<NoticeDTO, Notice>();
            var mapper = new Mapper(config);
            var data = mapper.Map<Notice>(noticeDTO);
            var repo = DataAccessFactory.NoticeDataAccess().Add(data);
            if (repo != null)
            {
                return mapper.Map<NoticeDTO>(repo);
            }
            return null;
        }

        public static List<NoticeDTO> Get()
        {
            var data = DataAccessFactory.NoticeDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Notice, NoticeDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<NoticeDTO>>(data);
        }

        public static NoticeDTO Get(int id)
        {
            var data = DataAccessFactory.NoticeDataAccess().Get(id);
            var config = MapServices.OneTimeMapping<Notice, NoticeDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<NoticeDTO>(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.NoticeDataAccess().Delete(id);
            return data;

        }

        public static NoticeDTO Update(NoticeDTO noticeDTO)
        {
            var config = MapServices.Mapping<Notice, NoticeDTO>();
            var mapper = new Mapper(config);
            var notice = mapper.Map<Notice>(noticeDTO);
            var data = DataAccessFactory.NoticeDataAccess().Update(notice);
            if (data != null)
            {
                return mapper.Map<NoticeDTO>(data);
            }
            return null;
        }
    }
}
