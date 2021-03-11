using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace curs3
{
    class Firma
    {
        List<Salariat> listaSal;

        public Firma() { this.listaSal = new List<Salariat>(); }
        public int NrSal => this.listaSal.Count;
        public static Firma operator +(Firma firma, Salariat s)
        {
            firma.listaSal.Add(s);
            return firma;
        }
        public int FondSalarii => this.listaSal.Sum(s=>s.Salariu);
        public Salariat this[int key]
        { 
            get
            {
                if (key>=this.listaSal.Count) throw new IndexOutOfRangeException() ;
                return listaSal[key];
            }
            /*set => SetValue(key, value);*/
        }
    }
}
