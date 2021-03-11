using System;
using System.Collections.Generic;
using System.Text;

namespace PAW_C2test
{
    class ProdusAdaos : ProdusAngro
    {
        private int adaos;

        public ProdusAdaos() { this.adaos = 10; }
        public ProdusAdaos(int cod, string denumire, int cantitate, float pret, int adaos) :
            base(cod, denumire, cantitate, pret)
        {
            this.adaos = adaos;
        }
        override protected void calculValoare()
        {
            base.calculValoare();
            this.valoare *= 1 + this.adaos / 100f;
        }
        public override string ToString()
        {
            return base.ToString() + " | Adaos: " + this.adaos;
        }
    }
}
