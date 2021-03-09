using System;
using System.Collections.Generic;
using System.Text;

namespace curs3
{
    class Salariat
    {
        string nume;
        int nrOre;
        int salOrar;
        int salariu;  //e read only
        int calculSalariu() => this.salariu = this.nrOre * this.salOrar;

        public Salariat()
        {
            this.nume = "Anonim";
            this.nrOre = 0;
            this.salOrar = 0;
        }
        public string Nume
        {
            get => this.nume;
            set => this.nume = value;
        }
        public int NrOre
        {
            get => this.nrOre;
            set => this.nrOre = value;
        }

        public int SalOrar
        {
            get => this.salOrar;
            set => this.salOrar = value;
        }
        public int Salariu => this.salariu = calculSalariu();

        public override string ToString()
            => $"Nume: {this.nume}  -> Salariu: {Salariu} \n" +
            $" Nr. ore: {this.nrOre} * Salariu/ora: {this.salOrar} ";

        public static Salariat operator +(Salariat s1, Salariat s2) =>
            new Salariat()
            {
                Nume = s1.Nume + s2.Nume,
                NrOre = s1.NrOre + s2.NrOre,
                SalOrar = s1.NrOre + s2.NrOre

            };

    }
    //daca + e overloaded, atunci si += e overloaded inplicit
}







