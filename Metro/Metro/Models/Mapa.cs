using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Metro.Models
{
    public class Mapa
    {
        
        // Mapa je sastavljen od liste Kvartova i liste Ruta

        
        public Mapa(List<Kvart> kvartovi, List<Ruta> rute, string imeMetroa )//,string izvor) 
        {
            Kvartovi = kvartovi;
            Rute = rute;
            ImeMetroa = imeMetroa;
          
           // Izvor = izvor;
        }  

        public List<Kvart> Kvartovi{ get; set;}
        public List<Ruta> Rute { get; set;}
        public string ImeMetroa { get; set;}
        public int duljina { get; set; }
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
        public int? DuljinaPuta(List<Kvart> stanice) //nazivi kvartova kao stanica string[] put= {"MAKSIMIR","SIGET","SPANSKO"}
        {
            int duljina = 0;
            string trenutnaLokacija = null;
            //char a = '-';
            //za svaku rutu u putu


            foreach (Kvart kvart in stanice)
            {
                /*
                if(kvart == a.ToString() )
                continue; */


                if (trenutnaLokacija == null)
                {
                    trenutnaLokacija = kvart.KvartIme;
                    continue;

                }

                //pronađi zadanu rutu (put), 

                Ruta trazi =
                    (from ruta in this.Rute
                     where ruta.Start.KvartIme == trenutnaLokacija
                          && ruta.Kraj.KvartIme == kvart.KvartIme
                     orderby ruta.Duljina
                     select ruta).DefaultIfEmpty(null).First();



                if (trazi == null)
                {
                    // NO SUCH ROUTE
                    return null;

                }

                duljina += trazi.Duljina;
                trenutnaLokacija = kvart.KvartIme;

            }


            return duljina;

        }


    }
}