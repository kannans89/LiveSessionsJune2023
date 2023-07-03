using EFCoreSqlConsoleApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMVCUnitTests
{
    [TestClass]
    public class OrganizationTest
    {
        [TestMethod]

        public void OrganizationToStringTest() {
            //Arrange
            Organization organistaion = new Organization();
            organistaion.Name = "Orange County";
            organistaion.Id = 101;
            organistaion.EmployeeCount = 1000;
            var expectToStringValue = "101,Orange County,1000";

            //Act
             var actualToStringValue = organistaion.ToString();

            //Assert
            
            Assert.AreEqual(expectToStringValue,actualToStringValue);
        
        }
    }
}
