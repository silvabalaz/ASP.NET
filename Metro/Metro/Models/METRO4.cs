using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Metro.Models;

namespace Metro.Models
{
    public class MyModel4
    {


        public int stops { get; set; }
        public stations stations { get; set; } 
   }

    public class stations {

        public string start { get; set; }
        public string end { get; set; }
    
    
    }

    public class MyModel5
    {

        public int count { get; set; }
        public string[] stops { get; set; }



        public Kvart[] SusjedniKvartovi(Kvart start, List<Ruta> Rute)
        {
            return
                (from ruta in Rute
                 where ruta.Start.KvartIme == start.KvartIme
                 select ruta.Kraj).ToArray<Kvart>();

        }




        public List<string> Stanice(Kvart start, Kvart kraj, int brStanica, List<Ruta> Rute)
        {

            string[] result = new string[] { };
            List<string> podruta = new List<string>();


            Kvart[] susjedni = SusjedniKvartovi(start, Rute);

            foreach (Kvart r in susjedni)
            {


                if (brStanica - 1 > 1)
                {
                    List<string> podRuta = Stanice(r, kraj, brStanica - 1, Rute);


                    foreach (string ru in podRuta)
                    {

                        podruta.Add(r.KvartIme + "-" + ru);
                   

                    }

                }




                if (brStanica - 1 == 1 )
                {
                    List<string> podRuta = Stanice(r, kraj, brStanica - 1, Rute);


                    foreach (string ru in podRuta)
                    {

                        podruta.Add(r.KvartIme);


                    }

                }

                if (brStanica - 1 == 0)
                {
                    List<string> podRuta = Stanice(r, kraj, brStanica - 1, Rute);

                   
                }


                else if (r.KvartIme != kraj.KvartIme)
                {
                    Kvart[] susjedniZadnjeg = SusjedniKvartovi(r, Rute);
                    foreach (Kvart z in susjedniZadnjeg)
                    {
                        if (z.KvartIme == kraj.KvartIme)
                            
                            podruta.Add("-"+r.KvartIme);
                    }
                }


            }

            return podruta;

        }

        public List<string> PutBezCiklusa(Kvart start, Kvart kraj, List<Ruta> Rute)
        {


            int brStanica = 4;

            var rute = Stanice(start, kraj, brStanica , Rute);
            List<string> Noncycles = new List<string>();


            foreach (string ruta in rute)
            {
                var result = ruta.Substring(ruta.LastIndexOf('-') + 1);
                int count = ruta.Split('-').Length - 1;

                if ( count == 3)
                {
                    int i = ruta.LastIndexOf('-');
                    string ss = ruta.Substring(0,i) + result;
                    Noncycles.Add(ss);
                }

            }

        
            return Noncycles;
        }



    }
}  


    



