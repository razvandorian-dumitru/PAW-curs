using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PAW_Proiect.clase;

namespace PAW_Proiect.Formulare
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();


            Start start = new Start();

            start.Close(); // closes the Form2 instance.
        }

        private void addMaterieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMaterie addMaterie = new AddMaterie();
            addMaterie.Show();
        }

        private void addAnToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            AddAnUniversitar addAnUniversitar = new AddAnUniversitar();
            
        }
    }
}