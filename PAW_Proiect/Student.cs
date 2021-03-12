using System;

// ReSharper disable ClassNeverInstantiated.Global

namespace PAW_Proiect
{
    internal enum Finantare
    {
        TAXA,
        BUGET,
        BURSA
    }

    internal class Student : IFunctii, ICloneable, IComparable
    {
        private int cod;
        private string nume;
        private int varsta;
        private int[] note;
        private float medie;
        private Finantare finantare;

        public Student()
        {
            cod = 0;
            nume = "Anonim";
            varsta = 0;
            note = null;
            finantare = Finantare.TAXA;
        }

        public Student(int cod, string nume, int varsta, int[] note)
        {
            this.cod = cod;
            this.nume = nume;
            this.varsta = varsta;
            this.note = (int[]) note.Clone();
            var suma = 0;
            foreach (var nota in this.note)
                suma += nota;
            medie = (float) suma / this.note.Length;
            switch (medie)
            {
                case >= 9:
                    finantare = Finantare.BURSA;
                    break;
                case >= 6:
                    finantare = Finantare.BUGET;
                    break;
                case >= 5:
                    finantare = Finantare.TAXA;
                    break;
            }
        }

        #region interfete

        public int spuneAnNastere()
        {
            var anNastere = DateTime.Now.Year - varsta;
            //Console.WriteLine("Anul nasterii este {0}", anNastere);
            return anNastere;
        }

        public float calculMedie()
        {
            return (float) this;
        }

        public Finantare calculFinantare()
        {
            if (medie >= 9)
                return Finantare.BURSA;
            if (medie >= 6)
                return Finantare.BUGET;
            return Finantare.TAXA;
        }

        public object Clone()
        {
            var clona = (Student) MemberwiseClone();
            var noteNoi = (int[]) note.Clone();
            clona.note = noteNoi;
            return clona;
        }

        public int CompareTo(object obj)
        {
            var s = (Student) obj;
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
            if (s.note != null)
            {
                var suma = 0;
                for (var i = 0; i < s.note.Length; i++)
                    suma += s.note[i];
                return (float) suma / s.note.Length;
            }

            return 0;
        }

        //todo an nastere, poate o sa pot sa fac un autocomplete ceva la formuri

        public static Student operator +(Student s, int notaNoua)
        {
            var temp = new int[s.note.Length + 1];
            for (var i = 0; i < s.note.Length; i++)
                temp[i] = s.note[i];
            temp[temp.Length - 1] = notaNoua;
            s.note = temp;
            return s;
        }

        public static Student operator ++(Student s)
        {
            return s + 10;
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
                if (value >= 18) varsta = value;
            }
        }

        public int[] Note
        {
            get => note;
            set
            {
                if (value != null) note = (int[]) value.Clone();
            }
        }

        public float Medie => medie = calculMedie();
        public Finantare getFinantare => calculFinantare();

        public int this[int index]
        {
            get
            {
                if (note != null && index >= 0 && index < note.Length)
                    return note[index];
                return 0;
            }
            set
            {
                if (note != null && index > 0 && index <= note.Length
                    && value > 0 && value <= 10)
                    note[index] = value;
            }
        }

        public override string ToString()
        {
            var rezultat = "********** Student " + cod + " **********" +
                           Environment.NewLine + "Nume: " + nume +
                           Environment.NewLine + "Varsta: " + varsta +
                           Environment.NewLine + "Note: ";
            for (var i = 0; i < note.Length; i++)
                rezultat += note[i] + " ";
            rezultat += Environment.NewLine + "Media: " + Medie +
                        Environment.NewLine + "Finantare: " + getFinantare + Environment.NewLine;
            return rezultat;
        }

        #endregion
    }
}