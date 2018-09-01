using System.Collections.Generic;
using SMS.DomainEntites.Entities;

namespace SMS.BusinessLogicLayer.Interfaces
{
    public interface IAdminManager
    {
        List<Teacher> GetAllTeacher(string teacherId, bool isActive);
    }
}
