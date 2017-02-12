using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMF.Repository
{
    public interface IUserRepository
    {
        AspNetUser CheckUser(string Email);
    }

    public class UserRepository : IUserRepository
    {
        HomeMadeFoodEntities1 _db;


        public UserRepository(HomeMadeFoodEntities1 context)
        {
            _db = context;

        }

        public AspNetUser CheckUser(string Email)
        {

            var model = _db.AspNetUsers.Where(o => o.UserName == Email).FirstOrDefault();
            if (model != null)
            {
                return model;
            }
            return null;
        }
    }
}