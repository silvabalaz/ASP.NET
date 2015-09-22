using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro.Models
{
    //interface, klasa za generiranje objekta tipa Metro

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
                
            Dictionary<char, Kvart kvartRijecnik = new kvartRijecnik<char, Kvart> brojKvartova;
        
            kvartovi = kvartoviRijecnik.Values.ToList();
            rute.Add(new Ruta(kvart1,kvart2,duljina));
        }

        
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