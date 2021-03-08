using System;
using System.Collections.Generic;
using System.Text;

namespace PAW_C2test
{
    class ProdusAngro
    {
        protected int cod;
        protected string denumire;
        protected int cantitate;
        protected float pret;
        protected float valoare;

        public ProdusAngro()
        {

            this.cod = 0;
            this.denumire = "Anonim";
            this.cantitate = 0;
            this.pret = 0;
        }
        public ProdusAngro(int cod, string denumire, int cantitate, float pret)
        {

            this.cod = cod;
            this.denumire = denumire;
            this.pret = pret;
            this.cantitate = cantitate;
        }
        public ProdusAngro(ProdusAngro pa)
        {
            this.cod = pa.cod;
            this.denumire = pa.denumire;
            this.pret = pa.pret;
            this.cantitate = pa.cantitate;
        }
        public int Cod
        {
            get { return this.cod; }
            set { if (value >= 0) this.cod = value; }
        }
        public string Denumire
        {
            get { return this.denumire; }
            set { if (value.Length >= 0) this.denumire = value; }
        }
        public int Cantitate
        {
            get { return this.cantitate; }
            set { if (value >= 0) this.cantitate = value; }
        }
        public float Pret
        {
            get { return this.pret; }
            set { if (value >= 0) this.pret = value; }
        }
        public float Valoare
        {
            //doar get pt ca e valoare "read-only" in practica
            get { calculValoare(); return valoare; }

        }
        protected virtual void calculValoare() { this.valoare = this.pret * this.cantitate; }
        public override string ToString()
        {
            return "Cod: " + this.cod +
                " | Denumire: " + this.denumire +
                " | Pret: " + this.pret +
                " | Cantitate: " + this.cantitate +
                "\nTotal: " + this.Valoare;

        }


    }

}
