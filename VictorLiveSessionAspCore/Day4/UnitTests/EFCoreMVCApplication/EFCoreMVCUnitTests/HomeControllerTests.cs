using EFCoreMVCApplication.Controllers;
using EFCoreMVCApplication.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMVCUnitTests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void CheckIndexAction_NotReturingNull() {

           //Arrange
            HomeController controller = new HomeController(new FakeRepository());
            
            //Act
            var viewResult =controller.Index() as ViewResult;
           
            //Assert.IsNotNull(viewResult);
            Assert.IsTrue(viewResult != null);
            Assert.IsTrue(viewResult.Model == null);
            
        }
        [TestMethod]
        public void CheckDisplayAction_ModelHasData()
        {

            //Arrange
            HomeController controller = new HomeController(new FakeRepository());

            //Act
            var viewResult = controller.Display() as ViewResult;

            //Assert.IsNotNull(viewResult);
            Assert.IsTrue(viewResult != null);
            Assert.IsTrue(viewResult.Model != null);

        }

    }
}
