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
    class METRO_7ControllerTest
    {
         [TestClass]
    public class zagrebmetroControllerTest
    {

        [TestMethod]
        public void metro7Test()
        {

            // Arrange
            METRO_7Controller controller = new METRO_7Controller();
            //Act
            ViewResult result = controller.metro7() as ViewResult;
            //Assert 
            Assert.IsNotNull(result);

        }


        [TestMethod]
        public void metro7PostTest()
        {

           
            //Arange
           //MyModel1  request = new MyModel1() { stations = new string[] { "MAKSIMIR", "DUBRAVA" } };
           //MyModel2 expected = new MyModel2() { distance = 7 };

            METRO_7Controller controller = new METRO_7Controller();
            //Act
            //JsonResult result = controller.zagrebPost(request) as JsonResult;
            //string Json = new JavaScriptSerializer().Serialize(result.Data);
            //string expectedJson = new JavaScriptSerializer().Serialize(expected);
          
        
           // Assert
          // Assert.IsNotNull(result);
          // Assert.AreEqual(expectedJson, Json);
        }



    }
}
