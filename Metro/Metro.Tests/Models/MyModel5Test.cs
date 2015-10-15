using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Metro.Models;

namespace Metro.Tests.Models
{
    class MyModel5Test
    {
        [TestMethod]
        public void NajkracaRutaTest()
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


            MyModel6 model1 = new MyModel6() { stations = new List<Kvart> { new Kvart("MAKSIMIR"), new Kvart("SPANSKO")} };
            MyModel6 model2 = new MyModel6() { stations = new List<Kvart> { new Kvart("SIGET"), new Kvart("SIGET") } };
       

            //act
            //int distance1 = model1.NajkracaRuta(Lista);
            //int distance2 = model2.NajkracaRuta(Lista);
         

            //assert
            Assert.AreEqual<int>(9, distance1); //OK
            Assert.AreEqual<int>(9, distance2); //OK
          
        }


    }
}
