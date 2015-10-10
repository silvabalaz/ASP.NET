using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro.Models
{
    public class MyModel1
    {

     
        public string[] stations { get; set; }
        public int distance { get; set; }

        /*
        public int calculateDistance(string[] places) //nazivi kvartova kao stanica string[] put= {"MAKSIMIR","SIGET","SPANSKO"}
        {
            int duljina = 0;
            string trenutnaLokacija = null;
            //char a = '-';
            //za svaku rutu u putu


            foreach (string kvart in places)
            {
                
                if(kvart == a.ToString() )
                continue; 


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
        */

    }
}