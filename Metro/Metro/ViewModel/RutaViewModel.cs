using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Metro.Models;

namespace Metro.ViewModel
{
    public class RutaViewModel
    {

        public Kvart Start { get; set; }

        public Kvart Kraj { get; set; }

        public int IspisStringa { get; set; }
    }
}