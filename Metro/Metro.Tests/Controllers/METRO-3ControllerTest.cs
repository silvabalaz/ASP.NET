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
    class METRO_3ControllerTest
    {
         [TestClass]
    public class METRO_3ControllerTest
    {

        [TestMethod]
        public void metro3Test()
        {

            // Arrange
            METRO_3Controller controller = new METRO_3Controller();
            //Act
            ViewResult result = controller.metro3() as ViewResult;
            //Assert 
            Assert.IsNotNull(result);

        }


        [TestMethod]
        public void metro3GetTest()
        {

         
            //Arange
           string request = "SPANSKO";
            MyModel3 expected = new MyModel3() { count = 2,  roudtrips = new string[] { "SPANSKO-MEDVESCAK-SPANSKO", "SPANSKO-DUBRAVA-SIGET-SPANSKO" } };

            METRO_3Controller controller = new METRO_3Controller();
            //Act
            JsonResult result = controller.metro3Get(request) as JsonResult;
            string Json = new JavaScriptSerializer().Serialize(result.Data);
            string expectedJson = new JavaScriptSerializer().Serialize(expected);
          
        
           // Assert
           Assert.IsNotNull(result);
           Assert.AreEqual(expectedJson, Json);
        }



    }
}
