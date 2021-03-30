using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PAW_Proiect.clase;

namespace PAW_Proiect.Formulare
{
    public partial class AddStudent : Form
    {
        public List<Student> studentList1 = new List<Student>();

        public AddStudent()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e){
        /*{
            try
            {
                int cod = int.Parse(etCod.Text);
                string nume = etNume.Text;
                int varsta = int.Parse(numericVarsta.Text);

                string[] Snote = etNote.Text.Split(',');
                int[] note = new int[Snote.Length];
                for (int i = 0; i < Snote.Length; i++)
                    note[i] = Convert.ToInt32(Snote[i]);

                Student s = new Student(cod, nume, varsta, List < AnUniversitar > anlist);
                var rezultat = "********** Student Nr. " + s.Cod + " **********" +
                               Environment.NewLine + "Nume: " + s.Nume +
                               Environment.NewLine + "Varsta: " + s.Varsta +
                               Environment.NewLine + "Note: ";
                for (var i = 0; i < s.Note.Length; i++)
                    rezultat += s.Note[i] + " ";
                rezultat += Environment.NewLine + "Media: " + s.Medie +
                            Environment.NewLine + "Finantare: " + s.Finantare + Environment.NewLine;

                Console.WriteLine(s);
                MessageBox.Show(rezultat);
                studentList1.Add(s);
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Datele sunt eronate!");
            }
            finally
            {
                etCod.Clear();
                etNume.Clear();
                numericVarsta.Value = 0;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*StudentiForm studentiForm = new StudentiForm(studentList1);
            studentiForm.Show();*/
        }
    }
}