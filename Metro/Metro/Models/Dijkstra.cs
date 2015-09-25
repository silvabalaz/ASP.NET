﻿using System;
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

                udaljenosti.Add(k.ImeKvarta, Int32.MaxValue); // Int32.MaxValue je (111111.....1) u bazi 2, 32 jedinice 
                rute.Add(k.ImeKvarta, start.ImeKvarta);
            
            }

            //ne vracamo se ovdje, pa pretpostavljamo udaljenost=0
        
            if(!traziCiklus)
            {
                udaljenosti[start.ImeKvarta] = 0;
            }



            var bridovi = metro.Rute.ToList(); // casting iz IList u List

            var tren = start;

            //zelimo posjetiti svaki kvart ako je moguce

            while (posjetili.Keys.Count < broji)
            {

                if (traziCiklus)
                {
                    traziCiklus = false;

                }
                else {

                    posjetili.Add(tren.KvartIme, true);
                }

                // provjeri svaku rutu

                foreach (Ruta ruta in metro.SusjedniKvartovi(tren))
                {
                    //nikad vise ne provjeravaj ovu rutu
                    rute.Remove(ruta);

                    //ako nemamo rutu ili ako smo nasli bolju

                    if (udaljenosti[ruta.Kraj.KvartIme] == Int32.Maxvalue || udaljenosti[tren.KvartIme] + ruta.Duljina < udaljenosti[ruta.Kraj.KvartIme])
                    {
                        if (tren.KvartIme == start.KvartIme)
                        {
                            udaljenosti[ruta.Kraj.KvartIme] == ruta.Duljina;

                        }
                        else
                        { 
                            udaljenosti[ruta.Kraj.KvartIme] = udaljenosti[tren.KvartIme] + ruta.Duljina;
                        
                        }
                        rute[ruta.Kraj.KvartIme] = rute[tren.KvartIme] + "-" + ruta.Kraj;

                    }

                
                }
                //svi kvartovi koji su susjedni trenutno posjecenom kvartu

                List<string> susjedni = new List<string>();

                susjedni = susjedni.Union(metro.SusjedniKvartovi(tren).Select(Ruta => Ruta.Kraj.ImeKvarta)).ToList(); //unija svih susjednih kvartova kvartu tren
                // i to imekvartova na kraju rute, na kraju sve u listu, liststa 'susjedni'.

                foreach (string k in posjetili.Keys) {

                    susjedni = susjedni.Union(
                        metro.SusjedniKvartovi(new Kvart(k))
                        .Select(ruta => ruta.Kraj.Ime)).ToList();
                }

                // odredi Kvart najmanje udaljenosti, koji nije bio posjećen

                tren =
                     (from KeyValuePair<string, int> par in udaljenosti
                      where par.Key != tren.ImeKvarta
                      where !posjetili.Keys.Contains(par.Key)
                      where susjedni.Contains(par.Key)
                      orderby par.Value
                      select new Kvart(par.Key)).DefaultIfEmpty(null).First();

            
            }

        }



        protected Metro metro;
    }  


   
}