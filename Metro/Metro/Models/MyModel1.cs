using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro.Models
{
    public class MyModel1
    {

     
        public string[] stations { get; set; }
      

        
        public int DuljinaPuta( List<Ruta> Rute ) //nazivi kvartova kao stanica string[] put= {"MAKSIMIR","SIGET","SPANSKO"}
        {
            int duljina = 0;
            string trenutnaLokacija = null;
            //char a = '-';
            //za svaku rutu u putu


            foreach (string kvart in this.stations)
            {
                
                //if(kvart == a.ToString() )
                //continue; 


                if (trenutnaLokacija == null)
                {
                    trenutnaLokacija = kvart;
                    continue;

                }

                //pronađi zadanu rutu (put), 

                Ruta trazi =
                    (from ruta in Rute
                     where ruta.Start.KvartIme == trenutnaLokacija
                          && ruta.Kraj.KvartIme == kvart
                     orderby ruta.Duljina
                     select ruta).DefaultIfEmpty(null).First();



                if (trazi == null)
                {
                    // NO SUCH ROUTE
                    return 0;

                }

                duljina += trazi.Duljina;
                trenutnaLokacija = kvart;

            }


            return duljina;

        }
        

    }
}