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
            
            for (int j = 0; j < brojStanica - 1; j++)
            {
                foreach(Ruta r in Rute)
                {


                     if ((string.Compare(r.Start.KvartIme, this.stations[j]) == 0) && (string.Compare(r.Kraj.KvartIme, this.stations[j + 1]) == 0))
                    //if ((r.Start.KvartIme == this.stations[j]) && (r.Kraj.KvartIme == this.stations[j + 1]))

                   //( (Rute[i].Start.KvartIme.Equals(this.stations[j]) == true ) && (Rute[i].Start.KvartIme.Equals(this.stations[j]) ==true) )
                    {
                        duljina += r.Duljina;
                        break;
                    }



                }

            }  
            
           
            return duljina;
            
        }


    }
}