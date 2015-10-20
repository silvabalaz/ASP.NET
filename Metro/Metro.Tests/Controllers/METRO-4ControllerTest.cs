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
    public class metro4ControllerTest
    {

        [TestMethod]
        public void metro4Test()
        {

            // Arrange
            METRO4Controller controller = new METRO4Controller();
            //Act
            ViewResult result = controller.metro4() as ViewResult;
            //Assert 
            Assert.IsNotNull(result);

        }


        [TestMethod]
        public void metro4PostTest()
        {

           
            //Arange
            MyModel4  request = new MyModel4() { stations = new List<Kvart>{ new Kvart("MAKSIMIR"), new Kvart("SPANSKO") }, stops = 4 };
            MyModel5 expected = new MyModel5() { count= 3 , stops = new string[] {"SIGET-SPANSKO-MEDVESCAK","MEDVESCAK-SPANSKO-MEDVESCAK","MEDVESCAK-DUBRAVA-SIGET"} };

            METRO4Controller controller = new METRO4Controller();
            //Act
            JsonResult result = controller.metro4Post(request) as JsonResult;
            string Json = new JavaScriptSerializer().Serialize(result.Data);
            string expectedJson = new JavaScriptSerializer().Serialize(expected);
          
        
           // Assert
           //Assert.IsNotNull(result);
           //Assert.AreEqual(expectedJson, Json);
        }


    }
}
