using System;
using System.Collections.Generic;
using System.Linq;
using SMS.BusinessLogicLayer.Interfaces;
using SMS.DataAccessLayer;
using SMS.DataAccessLayer.Implementation;
using SMS.DataAccessLayer.Interfaces;
using SMS.DomainEntites.Entities;
using Dapper;

namespace SMS.BusinessLogicLayer.Implementations
{
    public class UserManager : IUserManager
    {
      //  private readonly IGenericRepository<User> _user = null;
        private readonly MyDbContext _context = null;
        private readonly DapperRepository _dapperRepository = null;

        public UserManager()
        {
         //   _user = new GenericRepository<User>();
            _context = DbConnection.GetContext();
            _dapperRepository = new DapperRepository();
        }

        public void AddNewUser(User objUser)
        {
           //_user.Insert(objUser);
           //_user.Save();
        }

        public void DeleteUserbyId(object id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
         //var result =  _user.GetAll();

         //List<User> listOfUsers = new List<User>();
         //   foreach (var myObj in result)
         //       listOfUsers.Add(myObj);
         //   return listOfUsers;
        var reader = _dapperRepository.Querymultiple(StoredProcedure.GetAllUser, null);
        var user = reader.Read<User>().ToList();
        return user;
        }

        public User GetUserById(int id)
        {
            var param = new DynamicParameters();
            param.Add("@pId", id);
            var reader = _dapperRepository.Querymultiple(StoredProcedure.GetUserById, param);
            var user = reader.Read<User>().FirstOrDefault();
            return user;
        }

        public void UpdateUser(User objUser)
        {
            throw new NotImplementedException();
        }
    }
}
