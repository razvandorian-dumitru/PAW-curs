using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public enum Finantare
    {
        Taxa, Buget, Bursa
    };
    public class Student
    {
        private int cod;
        private string nume;
        private int varsta;
        private float medie;
        private Finantare grad;

        public Student()
        {
            this.cod = 0;
            this.nume = "NULL";
            this.varsta = 0;
            this.medie = 0.0f;
            this.grad = Finantare.Taxa;
        }

        public Student(int cod, string nume, int varsta, float medie, Finantare grad)
        {
            this.cod = cod;
            this.nume = nume;
            this.varsta = varsta;
            this.medie = medie;
            this.grad = grad;

        }

        public Student(Student s)
        {
            this.cod = s.cod;
            this.nume = s.nume;
            this.varsta = s.varsta;
            this.medie = s.medie;
            this.grad = s.grad;

        }

        public void display()
        {

            Console.WriteLine("Cod: " + this.cod);
            Console.WriteLine("Nume: " + this.nume);
            Console.WriteLine("Varsta: " + this.varsta);
            Console.WriteLine("Medie: " + this.medie);
            Console.WriteLine("Medie: " + this.grad);

        }
        public int Cod
        {
            get { return this.cod; }
            set { if (value >= 100) this.cod = value; }
        }

        public string Nume
        {
            get { return this.nume; }
            set { if (value != null) this.nume = value; }
        }
        public int Varsta
        {
            get { return this.varsta; }
            set { if (value >= 18) this.varsta = value; }
        }
        public float Medie
        {
            get { return this.medie; }
            set { if (value >= 1) this.medie = value; }
        }

        public Finantare Grad
        {
            get { return this.grad; }
            set { this.grad = value; }
        }

        public override string ToString()
        {
            return "Cod: " + this.cod + ", Nume: " + this.nume + ", Varsta: " + this.varsta + ", Medie: " + this.medie + ", Grad Finantare: " + this.grad;
        }

    };
}

