using System;
using System.Collections.Generic;
using System.Web.Http;
using SMS.BusinessLogicLayer.Implementations;
using SMS.BusinessLogicLayer.Interfaces;
using SMS.DomainEntites.Entities;

namespace SMS.Services.WebAPI.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserManager _userManager;

        public UserController()
        {
            _userManager = new UserManager();
        }

        [HttpGet]
        public List<User> GetAllUsers()
        {
            var result = _userManager.GetAllUsers();
            return result;
        }

        [HttpPost]
        public void SaveUser(User user)
        {
            user.CreatedBy = "Indradeep";
            user.CreatedOn = DateTime.Now;
            user.ModifiedBy = "Indradeep";
            user.ModifiedOn = DateTime.Now;
            user.UserName = "test";
            _userManager.AddNewUser(user);
        }
    }
}
