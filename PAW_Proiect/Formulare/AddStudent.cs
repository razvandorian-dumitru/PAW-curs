using System;
using System.Windows.Forms;

namespace PAW_Proiect.Formulare
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(etCod.Text);
            string nume = etNume.Text;
            int varsta = int.Parse(numericVarsta.Text);
            int nota1 = int.Parse(etNota1.Text);
            int nota2 = int.Parse(etNota2.Text);
            int nota3 = int.Parse(etNota3.Text);
            Student s1 = new Student(cod, nume, varsta, new int[3] {nota1, nota2, nota3});

            Console.WriteLine(s1);
            tvStudent.Text = s1.ToString();
        }
    }
}