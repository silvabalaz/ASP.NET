using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro.Models
{
    public class MyModel1
    {


        public string[] stations { get; set; }



        public int DuljinaPuta(List<Ruta> Rute)
        {
            int duljina = 0;
          
            
            int brojStanica = stations.Length;
            
            for (int j = 0; j < brojStanica -1 ; j++)
            {
                int nasao = 0;

                foreach(Ruta r in Rute)
                {


                    if ((string.Compare(r.Start.KvartIme.ToUpper(), this.stations[j]) == 0) && ((string.Compare(r.Kraj.KvartIme.ToUpper(), this.stations[j + 1]) == 0)))
                    {
                        duljina += r.Duljina;
                        nasao = 1;
                        break; //nema ponavljanja ruta
                    }
                    else nasao = 1;


                }

                if (nasao == 0)
                    return 1999; //NO SUCH ROUTE
            }  
            
           
            return duljina;
            
        }


    }



    public class MyModel2
    {

        public int distance { get; set; }


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
