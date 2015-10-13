using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Metro.Controllers;
using Metro.Models;
using Newtonsoft.Json;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;

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

            zagrebmetroController controller = new zagrebmetroController();
            //Mapa metro = (Mapa)controller.TempData["M"];
           // Mapa metro = new Mapa("ZagrebMetro", "MAKSIMIR-DUBRAVA:7");
            List<Ruta> Lista  = new List<Ruta>()
            { 

                new Ruta(new Kvart("MAKSIMIR"), new Kvart("SIGET"),5), 
                new Ruta(new Kvart("SIGET"),new Kvart("SPANSKO"),4), 
                new Ruta(new Kvart("SPANSKO"),new Kvart("MEDVESCAK"),8),
                new Ruta(new Kvart("MEDVESCAK"),new Kvart("SPANSKO"), 8), 
                new Ruta(new Kvart("MEDVESCAK"),new Kvart("DUBRAVA"),6), 
                new Ruta(new Kvart("MAKSIMIR"), new Kvart("MEDVESCAK"),5), 
                new Ruta(new Kvart("SPANSKO"),new Kvart("DUBRAVA"), 2), 
                new Ruta(new Kvart("DUBRAVA"),new Kvart("SIGET"),3), 
                new Ruta(new Kvart("MAKSIMIR"),new Kvart("DUBRAVA"),7) 
            };
            MyModel1  request = new MyModel1() { stations = new string[] { "MAKSIMIR", "DUBRAVA" } };
           
        
            /*
            var Lista = new List<Ruta>()
            { 

                new Ruta(new Kvart("MAKSIMIR"), new Kvart("SIGET"),5), 
                new Ruta(new Kvart("SIGET"),new Kvart("SPANSKO"),4), 
                new Ruta(new Kvart("SPANSKO"),new Kvart("MEDVESCAK"),8),
                new Ruta(new Kvart("MEDVESCAK"),new Kvart("SPANSKO"), 8), 
                new Ruta(new Kvart("MEDVESCAK"),new Kvart("DUBRAVA"),6), 
                new Ruta(new Kvart("MAKSIMIR"), new Kvart("MEDVESCAK"),5), 
                new Ruta(new Kvart("SPANSKO"),new Kvart("DUBRAVA"), 2), 
                new Ruta(new Kvart("DUBRAVA"),new Kvart("SIGET"),3), 
                new Ruta(new Kvart("MAKSIMIR"),new Kvart("DUBRAVA"),7) 
            };

        */
              


            List<Ruta> r = new List<Ruta>();
            foreach (Ruta ru in Lista)
            { r.Add(ru); }

            MyModel2 model2 = new MyModel2() { distance = 0 };
            model2.distance = request.DuljinaPuta(r);

            // Act
            //if (controller.zagrebPost(request) != null)
            //{ JsonResult result = controller.zagrebPost(request) as JsonResult;
            // Assert
            Assert.IsNotNull(model2.distance);
            
        

         

            // Assert
            //Assert.IsNotNull(result);
            Assert.AreEqual(7, model2.distance);//result.Data);
           

        }
    }
}
