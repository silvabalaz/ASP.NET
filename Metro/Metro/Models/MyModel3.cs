using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro.Models
{
    public class MyModel3
    {
        public int count { get; set; }
        public string[] roudtrips { get; set; }
        

        public int PutCiklus(Kvart start, int maxPut, List<Ruta> Rute)
        {
           int nasao = 0;

           for(int i = 0; i < 4; i++  )

                if (Rute[i].Start.KvartIme == start.KvartIme)
                {
                  while (Rute[i - 1].Kraj.KvartIme == Rute[i].Start.KvartIme)
                   {      

                    if (Rute[i].Kraj.KvartIme == start.KvartIme)
                    {
                        nasao ++;;
                        break;
                    
                    }
                   }
                
                 if (nasao > 0) break;

            }

            return nasao;
        }
            
            
            var minRuta =
                (from ruta in Rute
                 orderby ruta.Duljina
                 select ruta.Duljina).First();

            var rute = Stanice(start, maxPut / minRuta, false);

            //izbaci ne-cikluse

            var neCiklusi =
               (from ruta in Rute
                /// where ruta[ruta.Length - 1] == start.KvartIme //usporediti stringove
                 where ruta.Duljina > 2 // mora imati vise od pocetne lokacije
                 where DuljinaPuta(ruta) <= maxPut
                 select ruta).Distinct().ToList(); 

            return neCiklusi.Count;

        }


        public int? BrojTrazenihRuta(Tuple<string[], int?, string> ruta) // Item3 je vrsta rute kakvu trazim u zadatku {"obicna","MaxTri","MaxCetiri", "najkracaRuta"}
        {
            int? broj = 0;

            try {

                switch (ruta.Item3) //ovisno koja je vrsta rute koje trazim, adekvatnu funkciju pozovi
                { 
                    
                    //slucajevi za duljinu obicne rute
                    
                    String.Compare("obicna",ruta.Item3): //compare two string funkcija treba

                        broj = this.DuljinaPuta(ruta.Item1);
                        break;

                    //slucajevi najvise tri stanice,moze biti i manje
                    case ruta.Item3 == "MaxTri" :
                        
                        var rute = this.Stanice(new Kvart(ruta.Item1.ElementAt(0)),3,false).Distinct<string>().ToList<string>();
                        
                        broj =
                             (from s in rute
                             where s.Length > 1
                             where s[s.Length-1] == ruta.Item1[2] // compare two strings funkcija 
                             select s).Count();
                        break;
                     
                    //slucajevi najvise cetiri stanice
                    case ruta.Item3 == "MaxCetiri":
                        rute = this.Stanice(new Kvart(ruta.Item1.ElementAt(0)), 4, true).Distinct<string>().ToList<string>();
                        broj =
                            (from s in rute
                             where s.Length > 1
                             where s[] == rute.Item1[2]
                             select s).Count();
                        break;
                        //nadji najkracu rutu

                        case ruta.Item3 =="najkracaRuta":
                        
                        Dijkstra D = new Dijkstra(metro);

                        var najkracaRuta = D.MinRuta(new Kvart(ruta.Item1[0]), ruta.Item1 == ruta.Item1); // ali negdje je crtica kao razlika dva kvarta 

                                 broj = minRoutes[ruta.Item1[2]].Item1;

                                
                        
                                 if (broj == Int32.MaxValue)
                                 {
                                     broj = null;
                                 }
                       
                                 break;
                                    
                                 }
            
            
            
            
            }
        
        
        }


        

        





    }
}