using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro.Models
{
    public class Dijkstra
    {
        
        //konstruktor

        public Dijkstra(Metro metro)
        {
            this.metro = metro;
        
        }



        //implementacija Dijkstrinog algoritma za trazenje
        //minimalne rute od startKvart-a
        //vraca Rijecnik sa duljinom od Starta do kljuca u rjecniku
        public Dictionary<string, Tuple<int, string>> MinRuta(Kvart start, bool traziCiklus)
        {
            var broji = metro.Kvartovi.Count; // broj kvartova u danom Metrou
        
            //zelimo pratiti vrijednosti ruta, koje smo prešli. Konačno vratiti vrijednost

            Dictionary<string, int> udaljenosti = new Dictionary<string, int>(broji);
            Dictionary<string, bool> posjetili = new Dictionary<string, bool>(broji);
            Dictionary<string, string> rute = new Dictionary<string, string>(broji);
            Dictionary<string, Tuple<int, string>> VratiVrijednost = new Dictionary<string, Tuple<int, string>>(broji);
        
            //inicijaliziraj na defaultne vrijednosti

            foreach(Kvart k in metro.Kvartovi)
            {

                udaljenosti.Add(k.ImeKvarta, Int32.MaxValue);
                rute.Add(k.ImeKvarta, start.ImeKvarta.ToString());
            
            }

            //ne vracamo se ovdje, pa pretpostavljamo udaljenost=0
        
            if(!traziCiklus)
            {
                udaljenosti[start.ImeKvarta] = 0;
            }

        }



        protected Metro metro;
    }  


   
}