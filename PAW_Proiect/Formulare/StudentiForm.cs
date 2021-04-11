using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
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
                final += student.ToString() + "\n\n";
            tvStudenti.Text = final;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void ListaStudenti_Load(object sender, EventArgs e)
        {
            refresh();
        }


        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (sfdScriereText.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(sfdScriereText.FileName);
                streamWriter.WriteLine(tvStudenti.Text);
                streamWriter.Close();
                MessageBox.Show("SUCCES");
            }
        }

        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);
                tvStudenti.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //export
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                XmlTextWriter writer = new XmlTextWriter(memoryStream, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;

                for (int i = 0; i < studentList2.Count; i++)
                {
                    writer.WriteStartDocument();

                    writer.WriteStartElement("Student " + i);

                    //cod
                    writer.WriteStartElement("Cod");
                    writer.WriteValue(studentList2[i].Cod);
                    writer.WriteEndElement();

                    //nume
                    writer.WriteStartElement("Nume");
                    writer.WriteValue(studentList2[i].Nume);
                    writer.WriteEndElement();

                    //varsta
                    writer.WriteStartElement("Varsta");
                    writer.WriteValue(studentList2[i].Varsta);
                    writer.WriteEndElement();

                    //sex
                    writer.WriteStartElement("Sex");
                    writer.WriteValue(studentList2[i].Sex);
                    writer.WriteEndElement();

                    //an
                    writer.WriteStartElement("An");
                    writer.WriteValue(studentList2[i].An);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Materii");

                    for (int j = 0; j < studentList2[i].MateriiList.Count; j++)
                    {
                        writer.WriteStartElement("Materie ");

                        writer.WriteStartElement("Denumire");
                        writer.WriteValue(studentList2[i].MateriiList[j].Denumire);
                        writer.WriteEndElement();

                        writer.WriteStartElement("Nota");
                        writer.WriteValue(studentList2[i].MateriiList[j].Nota);
                        writer.WriteEndElement();

                        writer.WriteStartElement("Credite");
                        writer.WriteValue(studentList2[i].MateriiList[j].Credite);
                        writer.WriteEndElement();

                        writer.WriteStartElement("Tip examen");
                        writer.WriteValue(studentList2[i].MateriiList[j].TipExamen.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();//materii
                    //nr credite
                    writer.WriteStartElement("Nr. Credite");
                    writer.WriteValue(studentList2[i].CrediteTotale);
                    writer.WriteEndElement();

                    //media generala
                    writer.WriteStartElement("Varsta");
                    writer.WriteValue(studentList2[i].Medie);
                    writer.WriteEndElement();

                    //finantare
                    writer.WriteStartElement("TipFinantare");
                    writer.WriteValue(studentList2[i].Finantare.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();

                    writer.WriteEndDocument();
                    MessageBox.Show("XML");
                }
                writer.WriteStartDocument();
                
                writer.WriteStartElement("TipFinantare");
                writer.WriteValue("test");
                writer.WriteEndElement();
                writer.WriteEndDocument();
                
                writer.Close();
                
                string str = Encoding.UTF8.GetString(memoryStream.ToArray());
                memoryStream.Close();

                StreamWriter streamWriter = new StreamWriter("fisier.xml");
                streamWriter.WriteLine(str);
                streamWriter.Close();
            }
            catch (FormatException exception)
            {
                MessageBox.Show("NU");
            }
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}