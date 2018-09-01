using System;
using System.Linq;
using System.Collections.Generic;
using SMS.BusinessLogicLayer.Interfaces;
using SMS.DataAccessLayer;
using SMS.DataAccessLayer.Implementation;
using SMS.DomainEntites.ViewModel;
using Dapper;
using SMS.DomainEntites.Entities;


namespace SMS.BusinessLogicLayer.Implementations
{
    public class AdminManager : IAdminManager
    {
        private readonly DapperRepository _dapperRepository = null;

        public AdminManager()
        {
            _dapperRepository = new DapperRepository();
        }

       public List<Teacher> GetAllTeacher(string teacherId, bool isActive)
       {
            var param = new DynamicParameters();
            param.Add("@pTeacherId", teacherId);
            param.Add("@pIsActive", isActive);
            try
            {
                using (var reader = _dapperRepository.Querymultiple("GetAllTeacher", param))
                {
                    var listOfTeachers = reader?.Read(typeof(Teacher));
                    return listOfTeachers.Cast<Teacher>().ToList();
                }
            }
            catch (Exception exp)
            {
                throw;
            }
        }


    }
}
