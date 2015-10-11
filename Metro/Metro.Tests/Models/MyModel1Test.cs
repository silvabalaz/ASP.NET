using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Metro.Models;

namespace Metro.Tests.Models
{
    [TestClass]
    public class MyModel1Test
    {
        
       
       
        [TestMethod]
        public void DuljinaPutaTest()
        {
             //arrange
            var Lista = new List<Ruta>
            { 

                new Ruta(new Kvart("MAKSIMIR"), new Kvart("SIGET"),5), 
                new Ruta(new Kvart("SIGET"),new Kvart("SIGET"),4), 
                new Ruta(new Kvart("SPANSKO"),new Kvart("MEDVESCAK"),8),
                new Ruta(new Kvart("MEDVESCAK"),new Kvart("SPANSKO"), 8), 
                new Ruta(new Kvart("MEDVESCAK"),new Kvart("DUBRAVA"),6), 
                new Ruta(new Kvart("MAKSIMIR"), new Kvart("MEDVESCAK"),5), 
                new Ruta(new Kvart("MAKSIMIR"),new Kvart("MEDVESCAK"),5),
                new Ruta(new Kvart("SPANSKO"),new Kvart("DUBRAVA"), 2), 
                new Ruta(new Kvart("DUBRAVA"),new Kvart("SIGET"),3), 
                new Ruta(new Kvart("MAKSIMIR"),new Kvart("DUBRAVA"),7) 
            };

    
            MyModel1 model1 = new MyModel1() { stations = new string[] { "MAKSIMIR", "SIGET", "SPANSKO" } };
            MyModel1 model2 = new MyModel1() { stations = new string[] { "MAKSIMIR", "MEDVESCAK" } };
            MyModel1 model3 = new MyModel1() { stations = new string[] { "MAKSIMIR", "MEDVESCAK", "SPANSKO" } };
            MyModel1 model4 = new MyModel1() { stations = new string[] { "MAKSIMIR", "DUBRAVA", "SIGET","","" } };
            MyModel1 model5 = new MyModel1() { stations = new string[] { "MAKSIMIR", "SIGET", "SPANSKO" } };

            //act
            int distance1 = model1.DuljinaPuta(Lista);
            int distance2 = model2.DuljinaPuta(Lista);
            int distance3 = model3.DuljinaPuta(Lista);
            int distance4 = model4.DuljinaPuta(Lista);
            int distance5 = model5.DuljinaPuta(Lista);

           //assert
            Assert.AreEqual<int>(9, distance1); //ispadne 5
            //Assert.AreEqual<int>(5, distance2); //OK
            //Assert.AreEqual<int>(13, distance3); //OK
            //Assert.AreEqual<int>(22, distance4); //ispadne 10
           // Assert.AreEqual<int>(1999, distance4); //NO SUCH ROUTE, ispadne 10
        }
    }
}
