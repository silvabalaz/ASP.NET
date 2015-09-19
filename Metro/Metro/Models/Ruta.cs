using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace Metro.Models
{
    public class Ruta
    {
        

        //konstruktor 
        public Ruta( Kvart start, Kvart kraj, int duljina )
        {

            Start = start;
            Kraj = kraj;
            Duljina = duljina;

        }

        public Kvart Start { get; set; }
        public Kvart Kraj { get; set; }
        public int Duljina { get; set; }
    }
    /*
     public override string ToString()
        {
            return "Od " + Start.KvartIme + " do " + Kraj.KvartIme + " duljine " + Duljina;
        }
    */
}