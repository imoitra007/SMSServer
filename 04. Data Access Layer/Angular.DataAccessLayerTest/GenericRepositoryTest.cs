using System;
using System.Collections.Generic;
using Angular.DataAccessLayer.Implementation;
using Angular.DataAccessLayer.Interfaces;
using Angular.DomainEntites;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Angular.DataAccessLayerTest
{
    [TestClass]
    public class GenericRepositoryTest
    {
        [TestMethod]
        public void GetAllTest()
        {
            Employee obj = new Employee();
            IGenericRepository<Employee> emp = new GenericRepository<Employee>();
            var test = emp.GetAll();
            Assert.IsNotNull(test);

        }
        [TestMethod]
        public void GetByIdTest()
        {
            Employee obj = null;
            IGenericRepository<Employee> emp = new GenericRepository<Employee>();
            obj = emp.GetById(3);
            Assert.IsNotNull(obj);

        }

        [TestMethod]
        public void InsertTest()
        {
            Department it = new Department() { Name = "HR" };
            it.Employees = new List<Employee>
            {
                new Employee { FirstName="Indradeep", LastName="Moitra", Email  = "dd@gmail.com"},
                new Employee { FirstName="Mahua", LastName="Moitra", Email  = "mm@gmail.com"}
            };

            IGenericRepository<Department> dept = new GenericRepository<Department>();
            dept.Insert(it);
            dept.Save();


        }

        [TestMethod]
        public void UpdateTest()
        {
            Department it = new Department();
            it.Name = "IT";
            it.DepartmentId = 7;


            IGenericRepository<Department> dept = new GenericRepository<Department>();
            dept.Update(it);
            dept.Save();


        }

        [TestMethod]
        public void DeleteTest()
        {
            IGenericRepository<Employee> dept = new GenericRepository<Employee>();
            dept.Delete(4);
            dept.Save();
        }
    }
}
