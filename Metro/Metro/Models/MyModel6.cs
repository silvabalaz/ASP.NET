using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro.Models
{
    public class MyModel6
    {

        public class Pair<string, string> //stations
        {
            public Pair()
            {
            }

            public Pair(string Start, string End)
            {
                this.start = Start;
                this.end = End;
            }

            public string start { get; set; }
            public string end { get; set; }
        };


        public Ruta NajkracaRuta(List<Ruta> Rute, List<Ruta> Zadana)
        {
            

            return (Ruta)minRuta;
        }
    }
}