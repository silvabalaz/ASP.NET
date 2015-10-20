using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Metro.Models;

namespace Metro.Tests.Models
{
    [TestClass]
    class MyModel4Test
    {
        [TestMethod]
        public void PutBezCiklusaTest()
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


            MyModel4 model1 = new MyModel4() { stations = { new Kvart("MAKSIMIR"), new Kvart("SPANSKO") } }; //TU BI TRBEALO BTI : start: end:
     
            //act
            //MyModel5 result = model1.PutBezCiklusa(Lista);
             MyModel5 expected = new MyModel5{ count = 3, stops = new string[]{"SIGET-SPANSKO-MEDVESCAK","MEDVESCAK-SPANSKO-MEDVESCAK","MEDVESCAK-DUBRAVA-SIGET"} };

            //assert
           // Assert.AreEqual(expected, result); //OK
         
        }


    }
}
