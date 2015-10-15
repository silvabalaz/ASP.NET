using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Metro.Models;

namespace Metro.Tests.Models
{
    class MyModel3Test
    {
        [TestMethod]
        public void PutCiklusTest()
        {

            //arrange
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

            string request = "SPANSKO";
            MyModel3 expected = new MyModel3() { count= 2, roudtrips = new string[] { "SPANSKO-MEDVESCAK-SPANSKO","SPANSKO-DUBRAVA-SIGET-SPANSKO" } };
          

            //act
            //MyModel3 result = request.PutCiklus(Lista);
        

            //assert
           // Assert.AreEqual(expected, result); 
          
        }


    }
}
