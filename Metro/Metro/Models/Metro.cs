using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro.Models
{
    public class Metro
    {
        
        // Metro je sastavljen od liste Kvartova i liste Ruta

        /*
        public Metro(IList<Kvart> kvartovi, IList<Ruta> rute, string imeMetroa )//,string izvor) 
        {
            Kvartovi = kvartovi;
            Rute = rute;
            ImeMetroa = imeMetroa;
           // Izvor = izvor;
        }  */

        public IList<Kvart> Kvartovi{ get; set;}
        public IList<Ruta> Rute { get; set;}
        public string ImeMetroa { get; set;}
        //public string izvor { get; set;}


        /*
        
        //dohvati sve rute koje idu iz startkvarta-a
        //vrati polje ruta, koje sadrze kvartove susjedne startKvartu

        public Ruta[] SusjedniKvartovi(Kvart startKvart)
        { 
                return
                    (from ruta in Rute
                     where ruta.Start.KvartIme == startKvart.KvartIme     
                     select ruta).ToArray<Ruta>();
        
        
        }
         
         */
    }
}