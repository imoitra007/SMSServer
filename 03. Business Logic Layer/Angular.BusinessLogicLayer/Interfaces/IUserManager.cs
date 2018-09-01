using System.Collections.Generic;
using SMS.DomainEntites.Entities;

namespace SMS.BusinessLogicLayer.Interfaces
{
    public interface IUserManager
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        void AddNewUser(User objEmployee);
        void UpdateUser(User objEmployee);
        void DeleteUserbyId(object id);

    }
}
