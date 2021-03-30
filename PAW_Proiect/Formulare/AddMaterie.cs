using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PAW_Proiect.clase;

namespace PAW_Proiect.Formulare
{
    public partial class AddMaterie : Form
    {
        private List<Materie> materiiList = new List<Materie>();

        public AddMaterie()
        {
            InitializeComponent();
        }

        private void btAddMaterie_Click(object sender, EventArgs e)
        {
            if (etDenumire.Text == "")
                errorMaterie.SetError(etDenumire, "Introduceti denumirea!");
            else if (Convert.ToInt32(numCredite.Text) < 1 ||
                     Convert.ToInt32(numCredite.Text) > 6)
                errorMaterie.SetError(numCredite, "Nr de credite nu este valid!");
            else if (Convert.ToInt32(numNota.Text) < 1 ||
                     Convert.ToInt32(numNota.Text) > 10)
                errorMaterie.SetError(numNota, "Nr de credite nu este valid!");
            else
            {
                string denumire = etDenumire.Text;
                int nrCredite = Convert.ToInt32(numCredite.Text);
                int nota = Convert.ToInt32(numNota.Text);
                Materie materie1 = new Materie(denumire, nrCredite, nota);
                materiiList.Add(materie1);
                MessageBox.Show(materie1.ToString());
                etDenumire.Clear();
                numCredite.Value = 1;
                numNota.Value = 1;
            }
        }
    }
}