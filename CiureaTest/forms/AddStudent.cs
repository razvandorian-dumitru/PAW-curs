using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CiureaTest.clase;

namespace CiureaTest
{
    public partial class AddStudent : Form
    {
        public List<Student> studentList = new List<Student>();

        public AddStudent()
        {
            InitializeComponent();
        }


        private void btAddStud_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(tbCod.Text);
            string nume = tbNume.Text;
            string[] noteS = tbCod.Text.Split(",");
            int[] note = new int[noteS.Length];

            for (int i = 0; i < noteS.Length; i++)
                note[i] = Convert.ToInt32(noteS[i]);

            Student stoodent = new Student(cod, nume, note);
            MessageBox.Show(stoodent.ToString());
            studentList.Add(stoodent);
            tbCod.Clear();
            tbNume.Clear();
            tbNote.Clear();
        }

        private void btList_Click(object sender, EventArgs e)
        {
            ListForm listForm = new ListForm(studentList);
            listForm.Show();
        }
    }
}