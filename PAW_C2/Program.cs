using System;
using System.Collections.Generic;

namespace PAW_C2test
{
    interface IFigura
    {
        //ca un contract
        //contine declararile
        //toate elementele sunt publice
        //nu putem avea atribute, deci nu se pot instantia, decat prin intermediul claselor?


        double Aria
        {//nu putem spune cum va arata get-ul , dar putem spune ca aria va fi de tip read-only
            get;
        }
        double Perimetru
        { get; }
    }

    //CLASA ABSTRACTA
    //daca sintactic apare ca o mostenire, in acest caz vorbim de implementarea unei interfete
    //putem mosteni o singura clasa in C#, dar un nr indiferent de interfete
    //putem avea atribute, desi nu poate fi instantiata

    abstract class Figura : IFigura
    {//clasa abstracta inchide ierarhii 
     //ca un fel de numitor comun pt toate clasele

        protected int dimensiune;
        protected double aria, perimetru;
        public Figura() { this.dimensiune = 0; }
        public Figura(int dimensiune) { this.dimensiune = dimensiune; }

        //abstract -> metode virtua pure in C#
        protected abstract void calculAria();
        protected abstract void calculPerimetru();
        public double Aria { get { calculAria(); return this.aria; } }
        public double Perimetru { get { calculPerimetru(); return this.perimetru; } }
    }
    class Patrat : Figura
    {
        public Patrat(int dimensiune) : base(dimensiune) { }

        protected override void calculAria() { this.aria = this.dimensiune * dimensiune; }
        protected override void calculPerimetru() { this.perimetru = this.dimensiune * 4; }
    }
    class Cerc : Figura
    {
        public Cerc(int dimensiune) : base(dimensiune) { }

        protected override void calculAria() { this.aria = Math.PI * this.dimensiune * this.dimensiune; }
        protected override void calculPerimetru() { this.perimetru = 2 * Math.PI * this.dimensiune; }
    }
    class Dreptunghi : Figura
    {
        protected int latime;
        public Dreptunghi(int dimensiune, int latime) : base(dimensiune) { this.latime = latime; }
        protected override void calculAria() { this.aria = this.dimensiune * this.latime; }
        protected override void calculPerimetru() { this.perimetru = this.dimensiune * 2 + this.latime * 2; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region produs
            /*  List<ProdusAngro> produse = new List<ProdusAngro>();
                  void display()
                  {
                      for (int i = 0; i < produse.Count; i++)
                          Console.WriteLine("***** Produs " + (i + 1) + " *****\n" + produse[i] + "\n");
                  }

                  ProdusAngro pa1 = new ProdusAngro(100, "Lapte2", 200, 10);
                  ProdusAdaos pa2 = new ProdusAdaos(123, "Lapte", 3, 4.2f, 10);
                  pa2.Cantitate = 10;


                  produse.Add(pa1);
                  produse.Add(pa2);

                  display();*/
            #endregion
            #region figuri

            Figura figura;

            Patrat patrat = new Patrat(3);
            figura = patrat;
            Console.WriteLine(figura.Aria + " -> " + figura.Perimetru);

            Cerc cerc = new Cerc(10);
            figura = cerc;
            Console.WriteLine(figura.Aria.ToString("#.##") + " -> " + figura.Perimetru.ToString("#.##"));

            Dreptunghi dreptunghi = new Dreptunghi(10, 10);
            figura = dreptunghi;
            Console.WriteLine(figura.Aria + " -> " + figura.Perimetru);

            #endregion

        }
    }
}
