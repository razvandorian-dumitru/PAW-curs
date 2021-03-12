using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Policy;
using System.Windows.Forms;

namespace PAW_Proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void bt1_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(etCod.Text);
            string nume = etNume.Text;
            int varsta = int.Parse(etVarsta.Text);
            int nota1 = int.Parse(etNota1.Text);
            int nota2 = int.Parse(etNota2.Text);
            int nota3 = int.Parse(etNota3.Text);
            Student s1 = new Student(cod, nume, varsta, new int[3] {nota1, nota2, nota3});

            Console.WriteLine(s1);
            tvStudent.Text = s1.ToString();
        }

        private void btString_Click(object sender, EventArgs e)
        {
            
        }
    }
}