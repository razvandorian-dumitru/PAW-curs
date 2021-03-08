using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    interface IFigura
    {
        //interfata are toate atributele publice
        double Aria
        { //pot avea metode/proprietati, toate publice 
          //nu pot avea atribute
          //nu se pot instantia

            get;//inseamna ca e read-only, nu are set
        }
        double Perimetru { get; }

    }
    abstract class Figura : IFigura
    {

        protected int dimensiunea;
        protected double aria;
        protected double perimetru;
        public Figura() { this.dimensiunea = 0; }
        public Figura(int fd) { this.dimensiunea = fd; }

        protected abstract void calculAria();
        protected abstract void calculPerimetru();

        public double Aria
        {
            get { calculAria(); return this.aria; }
        }
        public double Perimetru
        {
            get { calculPerimetru(); return this.perimetru; }
        }

        class Patrat : Figura
        {

            public Patrat(int k) : base(k) { }

            protected override void calculAria() { this.aria = this.dimensiunea * this.dimensiunea; }
            protected override void calculPerimetru() { this.perimetru = 4 * this.dimensiunea; }

        }
        class Cerc : Figura
        {

            public Cerc(int k) : base(k) { }

            protected override void calculAria() { this.aria = Math.PI * dimensiunea * dimensiunea; }
            protected override void calculPerimetru() { this.perimetru = 2 * Math.PI * dimensiunea; }

        }

        class Dreptunghi : Figura
        {
            int dimensiune2;
            public Dreptunghi(int dim1, int dim2) : base(dim1) { dimensiune2 = dim2; }

            protected override void calculAria() { this.aria = dimensiunea * dimensiune2; }
            protected override void calculPerimetru() { this.perimetru = 2 * dimensiune2 + 2 * dimensiunea; }

        }
        class Program
        {
            static void Main(string[] args)
            {
                Figura f1;
                Patrat p1 = new Patrat(3);
                Cerc c1 = new Cerc(5);
                f1 = p1;
                Console.WriteLine("Aria: {0}\nPerimetru: {1}", p1.aria, p1.perimetru);
                f1 = c1;
                Console.WriteLine("Aria: {0}\nPerimetru: {1}", p1.aria, p1.perimetru);




  
            }
        }
    }
}
