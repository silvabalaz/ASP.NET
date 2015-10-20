using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Metro.Models;
using System.Collections;

namespace Metro.Models
{
    public class MyModel3
   {
        

        public int count { get; set; }
        public string[] roudtrips { get; set; }
        
     


        public Kvart[] SusjedniKvartovi(Kvart start, List<Ruta> Rute)
        { 
            return
                (from ruta in Rute
                 where ruta.Start.KvartIme == start.KvartIme
                 select ruta.Kraj).ToArray<Kvart>();
                
        } 




        public List<string> Stanice(Kvart start, int brStanica, List<Ruta> Rute) 
        {
           
            string[] result = new string[] { };
            List<string> podruta = new List<string>();
    

            Kvart[] susjedni = SusjedniKvartovi(start, Rute); 
            
            foreach (Kvart r in susjedni) 
            { 
                
                if (brStanica - 1 > 0)
                {
                    List<string> podRuta = Stanice(r, brStanica - 1, Rute);
                  

                    foreach (string ru in podRuta)
                    {

                        podruta.Add(start.KvartIme + "-" + ru); 
                    

                    }

                }
                else podruta.Add(start.KvartIme);
            
            }
        
           //podruta.Add("-" + start.KvartIme); 
         
   
            return podruta;

          }

        public List<string> PutCiklus(Kvart start, List<Ruta> Rute, int BrStanica) 
        {

            BrStanica++;
    
            
                var rute = Stanice(start, BrStanica,Rute);
                List<string> cycles = new List<string>();
           
           
            foreach(string ruta in rute)
            {
                var result = ruta.Substring(ruta.LastIndexOf('-') + 1);
                int count = ruta.Split('-').Length -1 ;
            
                if((result == start.KvartIme)&&(count > 2))
                {
                   
                    cycles.Add(ruta); 
                }
            
            }

   
           return cycles;      
      }
       


    }
}