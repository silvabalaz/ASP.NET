using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro.Models
{
    //klasa Kvart
    public class Kvart
    {
        

        //konstruktor
        public Kvart(string kvartIme)
        {
            KvartIme = kvartIme;

        }

        public string KvartIme { get; set; }


    }
}