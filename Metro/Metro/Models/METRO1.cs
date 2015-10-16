using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Metro.Models;

namespace Metro.Models
{




  public class Kvart
    {
        //konstruktor

        public Kvart(string kvartIme)
        {
            KvartIme = kvartIme;

        }

        public string KvartIme { get; set; }


    }



    public class Ruta
    {

        //konstruktor 

        public Ruta(Kvart start, Kvart kraj, int duljina)
        {
            Start = start;
            Kraj = kraj;
            Duljina = duljina;

        }

        public Kvart Start { get; set; }
        public Kvart Kraj { get; set; }
        public int Duljina { get; set; }

         public static readonly ReadOnlyCollection<Ruta> SveRute;
         static readonly List<Ruta> sveRute;
      
        static ()
       {
        sveRute = new List<Ruta>();
        SveRute = new ReadOnlyCollection<Ruta>(sveRute);
       }


    public int Index { get; private set; }
    public Kvart A { get; private set; }
    public Kvart B { get { return Kvart.sviKvartovi[this.bIndex]; } }
    private readonly int bIndex;

    internal Ruta(Kvart a, int bIndex)
    {
        this.Index = sveRute.Count;
        this.A = a;
        this.bIndex = bIndex;
        sveRute.Add(this);
    }
    public override string ToString()
    {
        return this.Index.ToString();
    }


    }

       public sealed class Ciklus
    {
        
        public readonly ReadOnlyCollection<Ruta> Rute;
        private List<Ruta> rute;
        private bool IsComplete;

     internal void Build(Ruta ruta)
       {
        if (!IsComplete)
        {
            if (ruta == rute[0]) 
                IsComplete = true;
            else
                this.rute.Add(ruta);
        }
      }

     internal Ciklus(Ruta prvaRuta)
    {
        this.rute = new List<Ruta>();
        this.rute.Add(prvaRuta);
        this.Rute = new ReadOnlyCollection<Ruta>(this.rute);
    }

      public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        foreach (var ruta in this.rute)
        {
            result.Append(ruta.Index.ToString());
            if (ruta !=rute[rute.Count - 1])
                result.Append(", ");
        }
        return result.ToString();
    }


        public string  { get; set; }


    }




public sealed class Kvart
{
    public static readonly ReadOnlyCollection<Kvart> SviKvartovi;
    internal static readonly List<Kvart> sviKvartovi;
    static Node()
    {
        sviKvartovi = new List<Kvart>();
        SviKvartovi = new ReadOnlyCollection<Node>(sviKvartovi);
    }
    public static void SetReferences()
    {//call this method after all nodes have been created
        foreach (Ruta e in Rute.SveRute)
            e.A.ruta.Add(e);
    }

    //All edges linking *from* this node, not to it. 
    //The variablename "Edges" it quite unsatisfactory, but I couldn't come up with anything better.
    public ReadOnlyCollection<Rute> Rute { get; private set; }
    internal List<Rute> edge;
    public int Index { get; private set; }
    public Kvart(params int[] nodesIndicesConnectedTo)
    {
        this.ruta = new List<Rute>(nodesIndicesConnectedTo.Length);
        this.Rute = new ReadOnlyCollection<Edge>(edge);
        this.Index = allNodes.Count;
        allNodes.Add(this);
        foreach (int nodeIndex in nodesIndicesConnectedTo)
            new Ruta(this, nodeIndex);
    }
    public override string ToString()
    {
        return this.Index.ToString();
    }
}












    public class Mapa
    {
      
        public Mapa(string imeMetroa , string izvor) 
        {
            ImeMetroa = imeMetroa;
            Izvor = izvor;
        }  

       
         public List<Ruta> KonstrukcijaRuta() {

             List<Ruta> Rute = new List<Ruta>();

            

             string[] sp = this.Izvor.Split(',');

                foreach (string dataItem in sp)
                {

                    var results = dataItem.Split('-');
                    string a = results[0];
                    string b = results[1]; 
                    var dot = b.Split(':'); 
                    string c = dot[0];
                    var d = dot[1];
                    int duljina = Int32.Parse(d);

                    Kvart kvart1 = new Kvart(a);
                    Kvart kvart2 = new Kvart(c);
                  
                  

                    Ruta temp = new Ruta(kvart1, kvart2, duljina);
                    Rute.Add(temp);
                  
                   
                }


                return Rute;



        }

     
        public string ImeMetroa { get; set;}
        public string Izvor { get; set;}
        
    }
}