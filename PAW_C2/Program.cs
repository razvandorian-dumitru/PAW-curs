using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_C2
{

    class Produs
    {
        int cod;
        string denumire;
        float pret;
        int cantitate;

        double valoare;
        public Produs()
        {

            this.cod = 0;
            this.denumire = "NULL";
            this.pret = 0;
            this.cantitate = 0;

        }
        public Produs(int cod, string denumire, float pret, int cantitate)
        {

            this.cod = cod;
            this.denumire = denumire;
            this.pret = pret;
            this.cantitate = cantitate;

        }
        public Produs(Produs p)
        {

            this.cod = p.cod;
            this.denumire = p.denumire;
            this.pret = p.pret;
            this.cantitate = p.cantitate;

        }

        public int Cod
        {
            get { return this.cod; }
            set { if (value != null) this.cod = value; }
        }
        public string Denumire
        {
            get { return this.denumire; }
            set { if (value != null) this.denumire = value; }
        }
        public float Pret
        {
            get { return this.pret; }
            set { if (value != null) this.pret = value; }
        }
        public int Cantitate
        {
            get { return this.cantitate; }
            set { if (value != null) this.cantitate = value; }
        }
        public double Valoare
        {
            //proprietate read-only
            get { total(); return this.valoare; }
        }


        void total() { this.valoare = this.cantitate * this.pret; }

        public override string ToString()
        {
            return "Cod: " + this.cod + "Denumire: " + this.denumire + "Pret: "
                + this.pret + "Cantitate: " + this.cantitate + "Total: " + Valoare + "\n";
        }



    }


    class Program
    {
        static void Main(string[] args)
        {

            //Produs p1 = new Produs(123, "Lapte", 25.0f, 2);
            Produs p1 = new Produs();

            Console.WriteLine(p1);



            



        }
    }
}
