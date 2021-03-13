using System;
using System.Windows.Forms;

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
            // button event in your Form2

            AddStudent addStudent = new AddStudent();
            addStudent.Show(); // Show Form3 and
            Start start = new Start();

            start.Close(); // closes the Form2 instance.
        }

        private void listaStudentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBStudenti dbStudenti = new DBStudenti();
            dbStudenti.Show();
            Start start = new Start();

            start.Close();
        }
    }
}