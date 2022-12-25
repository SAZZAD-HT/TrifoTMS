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
    public class AuthService
    {
        public static TokenDTO Authenticate(string email, string password)
        {
            var admin=DataAccessFactory.AdminAuthDataAccess().Authenticate(email,password);
            if (admin != null)
            {
                var token = new Token();
                token.Email = email;
                token.TKey = Guid.NewGuid().ToString();
                token.CreationTime = DateTime.Now;
                token.ExpirationTime = null;
                token.Type = "admin";
                var tk = DataAccessFactory.TokenDataAccess().Add(token);
                if (tk != null)
                {
                    var cfg = MapServices.OneTimeMapping<Token, TokenDTO>();
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenDTO>(token);
                }
                return null;
            }
            else
            {
                return null;
            }
           
           
        }
        public static bool IsValid(string token)
        {
            var data = DataAccessFactory.TokenDataAccess().Get(token);
            if(data == null)
            {
                return true;
            }return false;
        }

        public static TokenDTO logout(string token)
        {
            var data = DataAccessFactory.TokenDataAccess().Get(token);

            if (data != null)
            {
                data.ExpirationTime= DateTime.Now;
                var tk=DataAccessFactory.TokenDataAccess().Update(data);
                var cfg = MapServices.OneTimeMapping<Token, TokenDTO>();
                var mapper = new Mapper(cfg);
                return mapper.Map<TokenDTO>(tk);
            }
            return null;
        }
    }
}
