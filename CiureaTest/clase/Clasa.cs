using System;
using System.Collections.Generic;

namespace CiureaTest.clase
{
    public class Clasa
    {
        private string nume;
        private List<Student> studentList;

        public Clasa()
        {
            this.nume = "-";
            this.studentList = null;
        }

        public Clasa(string nume, List<Student> studentList)
        {
            this.nume = nume;
            this.studentList = studentList;
        }

        public override string ToString()
        {
            string rezultat = "";
            for (int i = 0; i < this.studentList.Count; i++)
                rezultat += studentList[i].ToString();
            return rezultat;
        }
    }
}