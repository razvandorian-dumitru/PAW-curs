using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using PAW_Proiect.clase;

namespace PAW_Proiect.Formulare
{
    public partial class StudentiForm : Form
    {
        private List<Student> studentList2;

        public StudentiForm(List<Student> lista)
        {
            InitializeComponent();
            studentList2 = lista;
        }

        private void refresh()
        {
            string final = "";
            foreach (Student student in studentList2)
                final += student.ToString() + "\n";
            tvStudenti.Text = final;
        }

        private void btScriere_Click(object sender, EventArgs e)
        {
            if (sfdScriereText.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(sfdScriereText.FileName);
                streamWriter.WriteLine(tvStudenti.Text);
                streamWriter.Close();
                MessageBox.Show("SUCCES");
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void ListaStudenti_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}