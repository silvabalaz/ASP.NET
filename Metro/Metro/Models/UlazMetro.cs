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

        public UlazMetro UnosIzDatoteke(string unos)
        { 
            string broj1,broj2;
               
            Dictionary<string, Kvart> kvartRijecnik = new kvartRijecnik<string, Kvart> (BrojKvartova);
            
            foreach(String k in Kvartovi)
            {
                Kvart kvart1 = new Kvart(broj1);
                Kvart kvart2 = new Kvart(broj2);
            
                //osiguramo da ne dodajemo kvartove više od jednom

                if(!kvartRijecnik.ContainsKey(broj1))
                {
                    kvartRijecnik.Add(broj1, kvart1);
                }
                if(!kvartRijecnik.ContainsKey(broj2))
                {
                    kvartRijecnik.Add(broj2, kvart2);
                
                }

            
            }

            kvartovi = kvartoviRijecnik.Values.ToList();
            
            // dana ruta nece se ponavljati, zadano u zadatku
 
            rute.Add(new Ruta(kvart1,kvart2,broj));
        

        
        izvor = unos;

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