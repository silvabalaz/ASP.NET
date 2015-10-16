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
    public class METRO5ControllerTest
    {


        [TestMethod]
        public void metro5Test()
        {

            // Arrange
            METRO5Controller controller = new METRO5Controller();
            //Act
            ViewResult result = controller.metro5() as ViewResult;
            //Assert 
            Assert.IsNotNull(result);

        }


        [TestMethod]
        public void metro5PostTest()
        {


            //Arange
            MyModel4 request1 = new MyModel4() { stations = new List<Kvart> { new Kvart("MAKSIMIR"), new Kvart("SPANSKO") } };
            MyModel2 expected1 = new MyModel2() { distance = 9 };
            MyModel4 request2 = new MyModel4() { stations = new List<Kvart> { new Kvart("MAKSIMIR"), new Kvart("SPANSKO") } };
            MyModel2 expected2 = new MyModel2() { distance = 9 };


            METRO5Controller controller = new METRO5Controller();
            //Act
            // JsonResult result1 = controller.metro5Post(request1) as JsonResult;
           // string Json1 = new JavaScriptSerializer().Serialize(result1.Data);
            string expectedJson1 = new JavaScriptSerializer().Serialize(expected1);


            // Assert
           // Assert.IsNotNull(result1);
           // Assert.AreEqual(expectedJson1, Json1);

            //JsonResult result2 = controller.metro5Post(request2) as JsonResult;
            //string Json2 = new JavaScriptSerializer().Serialize(result2.Data);
            string expectedJson2 = new JavaScriptSerializer().Serialize(expected2);


            // Assert
            //Assert.IsNotNull(result2);
           // Assert.AreEqual(expectedJson2, Json2);



        }


    }

}