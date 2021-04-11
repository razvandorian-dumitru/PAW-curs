using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PAW_Proiect.clase;

namespace PAW_Proiect.Formulare
{
    public partial class AddStudent : Form
    {
        public List<Student> studentList = new List<Student>();
        private List<Materie> materiiList = new List<Materie>();

        public AddStudent()
        {
            InitializeComponent();
        }

        #region materie

        public void display()
        {
            string final = "";
            for (int i = 0; i < materiiList.Count; i++)
                final += materiiList[i].ToString() + Environment.NewLine;
            lbMaterii.Text = final;
        }

        private void btAddMaterie_Click(object sender, EventArgs e)
        {
            if (tbDenumire.Text == "")
                errorProvider1.SetError(tbDenumire, "Introduceti denumirea!");
            else if (Convert.ToInt32(numCredite.Text) < 1 ||
                     Convert.ToInt32(numCredite.Text) > 6)
                errorProvider1.SetError(numCredite, "Nr de credite nu este valid!");
            else if (Convert.ToInt32(numNota.Text) < 1 ||
                     Convert.ToInt32(numNota.Text) > 10)
                errorProvider1.SetError(numNota, "Nr de credite nu este valid!");
            else
            {
                string denumire = tbDenumire.Text;
                int nrCredite = Convert.ToInt32(numCredite.Text);
                int nota = Convert.ToInt32(numNota.Text);

                Materie materie = new Materie(denumire, nrCredite, nota);
                materiiList.Add(materie);
                MessageBox.Show(materie.ToString());

                tbDenumire.Clear();
                numCredite.Value = 1;
                numNota.Value = 1;
                display();
            }
        }

        #endregion

        private void btNew_Click(object sender, EventArgs e)
        {
            {
                if (tbCod.Text == "")
                    errorProvider1.SetError(tbCod, "Introduceti codul !!!");
                else if (tbNume.Text == "")
                    errorProvider1.SetError(tbNume, "Introduceti numele !!!");
                else if (numericVarsta.Value < 18)
                    errorProvider1.SetError(numericVarsta, "Varsta<18 !!!");
                else if (Convert.ToChar(cbSex.Text) == ' ')
                    errorProvider1.SetError(cbSex, "Sexul nu este valid !!!");
                else if (rbAn1.Checked == false && rbAn2.Checked == false &&
                         rbAn3.Checked == false && rbAn4.Checked == false)
                    errorProvider1.SetError(gbAn, "Alegeti anul !!!");
                else
                {
                    int cod = int.Parse(tbCod.Text);
                    string nume = tbNume.Text;
                    int varsta = int.Parse(numericVarsta.Text);
                    string sex = cbSex.Text;
                    int an = 0;
                    if (rbAn1.Checked)
                        an = 1;
                    else if (rbAn2.Checked)
                        an = 2;
                    else if (rbAn3.Checked)
                        an = 3;
                    else if (rbAn4.Checked)
                        an = 4;

                    Student s = new Student(cod, nume, varsta, sex, an, materiiList);
                    string rezultat = "********** Student Nr. " + s.Cod + " **********" +
                                      Environment.NewLine + "Nume: " + s.Nume +
                                      Environment.NewLine + "Varsta: " + s.Varsta +
                                      Environment.NewLine + "Sex: " + s.Sex +
                                      Environment.NewLine + "Nr. Credite: " + s.CrediteTotale +
                                      Environment.NewLine + "An: " + s.An;
                    rezultat += Environment.NewLine + "Media: " + s.Medie +
                                Environment.NewLine + "Finantare: " + s.Finantare + Environment.NewLine;

                    Console.WriteLine(s);
                    MessageBox.Show(rezultat);
                    studentList.Add(s);

                    //clear
                    tbCod.Clear();
                    tbNume.Clear();
                    numericVarsta.Value = 0;
                    cbSex.Text = "";

                    rbAn1.Checked = false;
                    rbAn2.Checked = false;
                    rbAn3.Checked = false;
                    rbAn4.Checked = false;
                    tbDenumire.Clear();
                    numCredite.Value = 1;
                    numNota.Value = 1;
                    lbMaterii.Text = "";

                    materiiList = new List<Materie>();
                    
                }
            }
        }

        private void etCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void etNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void etDenumire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbSex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void etCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void etNume_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btLista_Click(object sender, EventArgs e)
        {
            StudentiForm studentiForm = new StudentiForm(studentList);
            studentiForm.Show();
        }

        private void fundalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                BackColor = dlg.Color;
        }

        private void fOndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                Font = dlg.Font;
        }

        private void AddStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.L)
            {
                
                btLista.PerformClick();
            }
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void xmlExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void cbSex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}