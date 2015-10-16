using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro.Models
{
    public class MyModel4
    {


        public int stops { get; set; }
        public List<Kvart> stations;
    


    }

    public class MyModel5
    {

        public int count { get; set; }
        public string[] stops { get; set; }


        /*
        
        public int PutBezCiklusa(Kvart start, List<Ruta> Rute)
        {

            for (int i = 0; i < 5; i++)
            {
                if (Rute[i].Start.KvartIme == start.KvartIme)
                {
                    while (Rute[j].Kraj.KvartIme == Rute[i].Start[j+1].KvartIme)
                    {

                        j++;
                    
                    
                    }

                
                
                
                }
                           
            
            }


            return count;
        }
        */
        


    }



}