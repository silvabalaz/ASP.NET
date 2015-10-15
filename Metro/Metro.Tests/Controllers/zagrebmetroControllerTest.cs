using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Metro.Controllers;
using Metro.Models;
using Newtonsoft.Json;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Web.Script.Serialization;
namespace Metro.Tests.Controllers
{
    [TestClass]
    public class zagrebmetroControllerTest
    {

        [TestMethod]
        public void zagrebTest()
        {

            // Arrange
            zagrebmetroController controller = new zagrebmetroController();
            //Act
            ViewResult result = controller.zagreb() as ViewResult;
            //Assert 
            Assert.IsNotNull(result);

        }


        [TestMethod]
        public void zagrebPostTest()
        {

           
            //Arange
            MyModel1  request = new MyModel1() { stations = new string[] { "MAKSIMIR", "DUBRAVA" } };
            MyModel2 expected = new MyModel2() { distance = 7 };

            zagrebmetroController controller = new zagrebmetroController();
            //Act
            JsonResult result = controller.zagrebPost(request) as JsonResult;
            string Json = new JavaScriptSerializer().Serialize(result.Data);
            string expectedJson = new JavaScriptSerializer().Serialize(expected);
          
        
           // Assert
           Assert.IsNotNull(result);
           Assert.AreEqual(expectedJson, Json);
        }
    }
}
