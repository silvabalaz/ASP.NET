using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Metro.Models;

namespace Metro.Models
{
    public class MyModel3
    {
        public int count { get; set; }
        public string[] roudtrips { get; set; }



        public Ruta[] SusjedniKvartovi(Kvart start, List<Ruta> Rute)
        { 
            return
                (from ruta in Rute
                 where ruta.Start.KvartIme == start.KvartIme
                 select ruta).ToArray<Ruta>();
                
        } // polje [ruta("Spansko""Medvescak"),ruta("Spansko""Dubrava")]




        public List<string> Stanice(Kvart start)
        {
            List<string> result = new List<string>();
            result.Add(start.KvartIme);
        

            //susjedni Kvartovi

            Ruta[] susjedni = SusjedniKvartovi(start,Rute); //unesene rute

            foreach (Ruta r in susjedni)
            { 
                //gradi put
                List<string> podRuta = Stanice(r.Kraj);
                //za svakupodRutu oznaci da smo bili u njoj
                foreach (string ru in podRuta)
                {
                    result.Add(start.KvartIme + "-" + ru);
                
                
                }
                    

            
              }
            result.Add("-" + start.KvartIme);
            return result;

          }

        public List<string> PutCiklus(Kvart start, List<Ruta> Rute)
        { 
            
            
            // najmanja ruta
                
              var minRuta =
                    (from ruta in Rute
                     orderby Rute.Duljina
                     select Rute.Duljina).First();  //ako ih ima vise, vrati prvu po redu  
                         
                         
             // naci sve rute sa 3 stanice
                var rute = Stanice(start);
  
            //izbaciti one koje ne zavrsavaju na nasem startu (ne cikluse)

            var cycles =
               (from ruta in rute  
                where ruta[ ruta.Lenght - 1] == start.KvartIme //
                where ruta.Length > 2 // mora biti bar jos jedna osim startne stanice
                select ruta).Distinct().ToList();

            return cycles;         
      }
       

          







        /*
        public MyModel3 PutCiklus(Kvart start, List<Ruta> Rute)
        {
            count = 0;
            
           for(int i = 0; i < 4; i++  )
           {
                if (Rute[i].Start.KvartIme == start.KvartIme)
                {
                    string temp = roudtrips.Append("-");
                    temp.Append(start.KvartIme);

                    while (Rute[i].Kraj.KvartIme == Rute[i + 1].Start.KvartIme)
                    {
                        roudtrips.Append(Rute[i].Kraj.KvartIme);

                        if (Rute[i + 1].Kraj.KvartIme == start.KvartIme)
                        {
                            count++;
                            roudtrips.Append(start.KvartIme);
                            break;

                        }


                     
                    }
                }
            }  

          return this;
        }
           
        */







    }
}