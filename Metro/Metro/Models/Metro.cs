using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro.Models
{
    public class Metro
    {
        // Metro je sastavljen od liste Kvartova i liste Ruta

        public Metro(IList<Kvart> kvartovi, IList<Ruta> rute, string imeGrafa)
        {
            Kvartovi = kvartovi;
            Rute = rute;
            ImeGrafa = imeGrafa;

        }

        public IList<Kvart> Kvartovi;
        public IList<Ruta> Rute;
        public string ImeGrafa;

        //dohvati sve rute koje idu iz startkvarta-a
        //vrati polje ruta koje su susjedne startKvartu
        public Ruta[] SusjedniKvartovi(Kvart startKvart)
        { 
                return
                    (from ruta in Rute
                     where ruta.Start.KvartIme == startKvart.KvartIme     
                     select ruta).ToArray<Ruta>();
        
        
        }
    }
}