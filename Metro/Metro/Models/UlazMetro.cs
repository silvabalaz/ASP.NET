using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro.Models
{

    //interface

    public class UlazMetro
    {
        
        //konstruktor
        public UlazMetro()
        {
        
            kvartovi = new List<Kvart>();
            rute = new List<Ruta>();
        
        }


        //unos je string iz kojega se radi Metro

        

        public UlazMetro UnosIzDatoteke()
        { 

           
               Dictionary<string, Kvart> kvartRijecnik = new kvartRijecnik<string, Kvart>();
            
          
               var result = "";
               Array userData = null;

               char[] delimiterChar = new char[3];

               delimiterChar[0] = '-';
               delimiterChar[1] = ':';


               var dataFile = Server.MapPath("~/App_Data/metro.txt");

               if (File.Exists(dataFile))
               {

                   userData = File.ReadAllLines(dataFile);

                   if (userData == null)
                   {
                       // Prazna datoteka.
                       result = "Datoteka je prazna.";
                   }
               }
               else
               {
                   // Datoteka ne postoji.
                   result = "Datoteka ne postoji.";
               }


               if (result == "")
               {

                   foreach (string dataLine in userData)
                   {


                       foreach (string dataItem in dataLine.Split(','))
                       {


                           var results = dataItem.Split('-');

                           string a = results[0];
                           string a1 = a.ToLower();
                           string b = results[1];
                           var dot = b.Split(':');
                           string c = dot[0];
                           string d = dot[1];


                           string c2 = c[0] + c.Substring(1).ToLower();




                           char[] s = a1.ToCharArray();
                           s[0] = char.ToUpper(s[0]);
                           string a2 = new string(s);


                           Kvart kvart1 = new Kvart(a2);
                           Kvart kvart2 = new Kvart(c2);

                           //osiguramo da ne dodajemo kvartove više od jednom

                           if (!kvartRijecnik.ContainsKey(a2))
                           {
                               kvartRijecnik.Add(a2, kvart1);
                           }
                           if (!kvartRijecnik.ContainsKey(c2))
                           {
                               kvartRijecnik.Add(c2, kvart2);

                           }


                       }

                   }
               }
                
            kvartovi = kvartRijecnik.Values.ToList(); //lista elemenata tipa Kvart
            
            // dana ruta nece se ponavljati, zadano u zadatku
 
            rute.Add(new Ruta(kvart1,kvart2,d));
        

        
           izvor = userData;

        return this;
    }

           public UlazMetro Ime(string ime)
        {
            this.ime = ime;
            return this;
        }

        public Metro getMetro()
        {
            return new Metro(kvartovi, rute, ime);
        
        }

        protected IList<Kvart> kvartovi;
        protected IList<Ruta> rute;

        protected string ime;
        protected string izvor;

        
    } 
}