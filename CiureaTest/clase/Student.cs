using System;
using System.Runtime.CompilerServices;

namespace CiureaTest.clase
{
    public class Student : ICloneable, IComparable
    {
        private int cod;
        private string nume;
        private int[] note;
        private float media;

        public Student()
        {
            this.cod = 0;
            this.nume = "-";
            this.note = null;
        }

        public Student(int cod, string nume, int[] note)
        {
            this.cod = cod;
            this.nume = nume;
            this.note = note;
        }

        public int Cod
        {
            get => cod;
            set => cod = value;
        }

        public string Nume
        {
            get => nume;
            set => nume = value;
        }

        public int[] Note
        {
            get => note;
            set => note = value;
        }

        public float Medie => media = calculeazaMedia();

        private float calculeazaMedia()
        {
            return (float) this;
        }

        public static explicit operator float(Student s)
        {
            float suma = 0;
            for (int i = 0; i < s.Note.Length; i++)
                suma += s.note[i];
            return suma / s.note.Length;
        }

        public object Clone()
        {
            var clona = (Student) MemberwiseClone();
            return clona;
        }

        public int CompareTo(object obj)
        {
            Student stud = (Student) obj;
            if ((float) this < (float) stud)
                return -1;
            if ((float) this > (float) stud)
                return 1;
            return string.Compare(this.Nume, stud.Nume);
        }

        public override string ToString()
        {
            string rezultat = "";
            rezultat += "Cod: " + this.Cod + Environment.NewLine +
                        "Nume: " + this.Nume + Environment.NewLine + "Note: " + Environment.NewLine;
            for (int i = 0; i < this.note.Length; i++)
                rezultat += "Nota " + (i + 1) + ": " + this.note[i];
            rezultat += Environment.NewLine + "Medie: " + this.Medie + Environment.NewLine;
            return rezultat;
        }
    }
}