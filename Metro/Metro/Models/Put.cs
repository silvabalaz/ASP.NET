using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Metro.Models
{
    public class Put
    {

        
        public Put(Metro metro)
        {

            MapaPuta = metro;
        
        }

        public Metro MapaPuta { get; set; }

        //Rekurzivna funkcija
        public List<string> Stanice(Kvart start, int maxStanica, bool tocanBrojStanica)
        {
            List<string> popisStanica= new List<string>();

            if (maxStanica == 0)
            {
                popisStanica.Add(start.ToString());
            
            }

            Ruta[] susjedni = MapaPuta.SusjedniKvartovi(start);
            
            foreach(Ruta ruta in susjedni)
            {
                List<string> putevi = Stanice(ruta.Kraj, maxStanica-1,tocanBrojStanica);
            
                // za svaki put oznacimo da smo ga prosli

                foreach (string put in putevi)
                {
                    putevi.Add(start.KvartIme + "-" + put);
                }

                if (!tocanBrojStanica)
                {
                    Stanice.Add(ruta.Start.KvartIme.ToString());
                }

            }
                return Stanice;
            
            }

        
        
        
        
        }


        //METRO-2 za dani put vraca duljinu puta

        public int? DuljinaPuta(string[] put) //nazivi kvartova kao stanica string[] put= {"MAKSIMIR","SIGET","SPANSKO"}
        {
            int duljina = 0;
            string trenutnaLokacija = null;



            //za svaku rutu u putu

            foreach (string kvart in put)
            {
                //preskoci
                if(kvart == '-' )
                continue;


                if (trenutnaLokacija == null)
                {
                    trenutnaLokacija = kvart;
                    continue;
                
                }

          //pronađi zadanu rutu (put)

          Ruta trazi =  
              (from ruta in MapaPuta.Rute
               where ruta.Start.KvartIme == trenutnaLokacija
                    && ruta.Kraj.KvartIme == kvart
                    orderby ruta.Duljina
                    select ruta).DefaultIfEmpty(null).First();



          if (trazi == null)
          { 
                // NO SUCH ROUTE
              return null;
          
          }

          duljina += trazi.Duljina;
          trenutnaLokacija = kvart;

            }


            return duljina;
        
        
        
        
        
        }


        
        // METRO-3 , METRO-4
        public int PutCiklus(Kvart start, int brStanica)
        {

            var minRuta =
                (from ruta in MapaPuta.Rute
                 orderby ruta.Duljina
                 select ruta.Duljina).First();
        }

        



        


    }
}

