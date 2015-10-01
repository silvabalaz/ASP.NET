using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Metro.Models
{
    public class Put
    {
        /*
        
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

       
        //METRO-2 za dani put vraca duljinu puta

        public int? DuljinaPuta(string[] put) //nazivi kvartova kao stanica string[] put= {"MAKSIMIR","SIGET","SPANSKO"}
        {
            int duljina = 0;
            string trenutnaLokacija = null;
            char a = '-';
           //za svaku rutu u putu

            foreach (string kvart in put)
            {
                //preskoci
                if(kvart == a.ToString() )
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

        public int PutCiklus(Kvart start, int maxPut)
        {
            var minRuta =
                (from ruta in MapaPuta.Rute
                 orderby ruta.Duljina
                 select ruta.Duljina).First();

            var rute = Stanice(start, maxPut / minRuta, false);

            //izbaci ne-cikluse

            var neCiklusi =
               (from ruta in rute
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


        

        */
    }
         
         
}

