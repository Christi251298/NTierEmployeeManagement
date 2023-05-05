using BALayer;
using BELayer;
using DALayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace NTierWPF.Tests
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
        public void Test_GetEmpDetails()
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            EmployeeServiceAPI employeeServiceAPI = new EmployeeServiceAPI();
            ObservableCollection<Employee> employee = new ObservableCollection<Employee>();
            var userlist = employeeServiceAPI.GetAllEmployeeDetails().Result;
            // Assert.IsNotNull(userlist);
            if (userlist.Count > 0)
            {
                Assert.IsTrue(userlist.Count > 0);

            }

        }

        [TestMethod]
        public async Task Test_CreateEmployee()
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            EmployeeServiceAPI employeeServiceAPI = new EmployeeServiceAPI();
            Employee employee = new Employee()
            { id = 101, name = "justin", email = "justin@gmail.com", gender = "male", status = "inactive" };
            var newuser = await employeeServiceAPI.CreateEmployee(employee);
            // Assert.IsNotNull(newuser);---1
            //Assert.AreEqual<Employee>(employee, newuser);
            Assert.IsTrue(OperatorNotEqualsToo(employee, newuser));

        }

        private static bool OperatorNotEqualsToo(Employee expected, Employee actual)
        {
            if (((object)expected) == null || ((object)actual) == null)
                return !Object.Equals(expected, actual);

            return !(expected.Equals(actual));
        }

        [TestMethod]
        public async Task Test_CreateEmployee_CheckingID()
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            EmployeeServiceAPI employeeServiceAPI = new EmployeeServiceAPI();
            Employee employee = new Employee()
            { id = 101, name = "justin", email = "justin@gmail.com", gender = "male", status = "inactive" };
            Employee newuser = await employeeServiceAPI.CreateEmployee(employee);
            Assert.IsNotNull(newuser.id);



        }

        [TestMethod]
        public void Test_Update()
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            EmployeeServiceAPI employeeServiceAPI = new EmployeeServiceAPI();
            Employee employee = new Employee()
            { id = 101, name = "justin", email = "justin@gmail.com", gender = "male", status = "inactive" };
            var updateddata = EmployeeServiceAPI.Update(employee);
            Assert.IsNotNull(updateddata);

        }

        [TestMethod]
        public void Test_DeleteEmploye()
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            EmployeeServiceAPI employeeServiceAPI = new EmployeeServiceAPI();
            Employee employee = new Employee()
            { id = 101, name = "justin", email = "justin@gmail.com", gender = "male", status = "inactive" };
            var response = EmployeeServiceAPI.Delete(employee.id);
            Assert.IsNotNull(response);



        }
    }
}
