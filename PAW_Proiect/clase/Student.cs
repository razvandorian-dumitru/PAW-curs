using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using PAW_Proiect;
using PAW_Proiect.clase;

// ReSharper disable ClassNeverInstantiated.Global

namespace PAW_Proiect.clase
{
    public enum Finantare
    {
        TAXA,
        BUGET,
        BURSA
    }

    public class Student : ICloneable, IComparable
    {
        private int cod;
        private string nume;
        private int varsta;
        private List<AnUniversitar> aniList;
        private float medieGenerala;
        private Finantare finantare;


        public Student()
        {
            cod = 0;
            nume = "Anonim";
            varsta = 0;
            this.aniList = null;
            finantare = Finantare.TAXA;
            medieGenerala = 0;
        }

        public Student(int cod, string nume, int varsta,
            List<AnUniversitar> anlist)
        {
            this.cod = cod;
            this.nume = nume;
            this.varsta = varsta;
            this.aniList = anlist;
            
        }

        #region interfete

        public int spuneAnNastere()
        {
            int anNastere = DateTime.Now.Year - varsta;
            //Console.WriteLine("Anul nasterii este {0}", anNastere);
            return anNastere;
        }

        public float calculMedieGenerala()
        {
            return (float) this;
        }

        public Finantare calculFinantare()
        {
            if (medieGenerala >= 9)
                this.finantare = Finantare.BURSA;
            else if (medieGenerala >= 6)
                this.finantare = Finantare.BUGET;
            else this.finantare = Finantare.TAXA;
            return this.finantare;
        }

        public object Clone()
        {
            var clona = (Student) MemberwiseClone();
            // var noteNoi = (int[]) note.Clone();
            // clona.note = noteNoi;
            return clona;
        }

        public int CompareTo(object obj)
        {
            Student s = (Student) obj;
            if ((float) this < (float) s)
                return -1;
            if ((float) this > (float) s)
                return 1;
            return string.Compare(nume, s.nume);
        }

        #endregion

        #region operatori

        //cast la float  
        public static explicit operator float(Student s)
        {
            if (s.aniList != null)
            {
                float suma = 0;
                foreach (AnUniversitar an in s.aniList)
                    suma += an.MediaAnuala;
                return (float) suma / s.aniList.Count;
            }

            return 0;
        }

        //todo an nastere, poate o sa pot sa fac un autocomplete ceva la formuri

        public static Student operator +(Student s, AnUniversitar an)
        {
            s.aniList.Add(an);
            return s;
        }

        #endregion

        #region acces si toString

        public int Cod
        {
            get => cod;
            set
            {
                if (value >= 0) cod = value;
            }
        }

        public string Nume
        {
            get => nume;
            set
            {
                if (value.Length >= 0) nume = value;
            }
        }

        public int Varsta
        {
            get => varsta;
            set
            {
                if (value >= 0) varsta = value;
            }
        }

        public List<AnUniversitar> AniList
        {
            get => aniList;
            set
            {
                if (value != null) aniList = value;
            }
        }

        public float Medie => medieGenerala = calculMedieGenerala();
        public Finantare Finantare => this.finantare = calculFinantare();

        public AnUniversitar this[int index]
        {
            get
            {
                if (aniList != null && index >= 0 && index < aniList.Count)
                    return aniList[index];
                return null;
            }
            set
            {
                if (aniList != null && index > 0 && index <= aniList.Count)
                    aniList[index] = value;
            }
        }

        public override string ToString()
        {
            string final = this.cod + " | " + this.nume + " | " + this.varsta + " |  Ani de Studiu: " +
                           Environment.NewLine;
            foreach (AnUniversitar an in aniList)
                final += an.ToString() + Environment.NewLine;
            final += "  | " + Medie + " | " + Finantare;
            return final;
        }

        #endregion
    }
}