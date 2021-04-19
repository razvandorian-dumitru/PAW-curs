using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using PAW_Proiect.clase;

namespace PAW_Proiect.Formulare
{
    public partial class StudentiForm : Form
    {
        private List<Student> studentList;

        public StudentiForm(List<Student> studentList)
        {
            InitializeComponent();
            this.studentList = studentList;
        }

        //functia de refresh pt treeview
        private void refresh()
        {
            tvStudenti.Nodes.Clear();
            TreeNode parinte = new TreeNode("Studenti");
            tvStudenti.Nodes.Add(parinte);
            foreach (Student student in studentList)
            {
                TreeNode nodCod = new TreeNode(student.Cod.ToString());

                TreeNode nodNume = new TreeNode(student.Nume);
                TreeNode nodVarsta = new TreeNode(student.Varsta.ToString());
                TreeNode nodSex = new TreeNode(student.Sex);
                TreeNode nodAn = new TreeNode(student.An.ToString());
                TreeNode nodMaterii = new TreeNode("Materii(" + student.MateriiList.Count + ")");
                for (int i = 0; i < student.MateriiList.Count; i++)
                {
                    TreeNode nodMaterie = new TreeNode(student.MateriiList[i].Denumire);

                    TreeNode nodCredit = new TreeNode(student.MateriiList[i].Credite.ToString());
                    TreeNode nodNota = new TreeNode(student.MateriiList[i].Nota.ToString());
                    TreeNode nodTip = new TreeNode(student.MateriiList[i].TipExamen.ToString());

                    nodMaterie.Nodes.Add(nodCredit);
                    nodMaterie.Nodes.Add(nodNota);
                    nodMaterie.Nodes.Add(nodTip);

                    nodMaterii.Nodes.Add(nodMaterie);
                }

                nodCod.Nodes.Add(nodNume);
                nodCod.Nodes.Add(nodVarsta);
                nodCod.Nodes.Add(nodSex);
                nodCod.Nodes.Add(nodAn);
                nodCod.Nodes.Add(nodMaterii);

                parinte.Nodes.Add(nodCod);
            }

            tvStudenti.ExpandAll();
        }

        private void ListaStudenti_Load(object sender, EventArgs e)
        {
            refresh();
        }

        //export Text
        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportText();
        }

        //export Xml
        private void menuXmlExp_Click(object sender, EventArgs e)
        {
            exportXml();
        }

        //export Binar
        private void binarExp_Click(object sender, EventArgs e)
        {
            exportBinar();
        }

        //import Text
        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        //import Xml
        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            importXml();
        }


        //import Binar
        private void binarImp_Click(object sender, EventArgs e)
        {
            importBinar();
        }


        #region exporturi

        private void exportText()
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

        private void exportBinar()
        {
            //todo binar export cum trebuie
            //se face pe acelasi fisier, deci nu mai trebuie sfd
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("fisierBinar.dat",
                FileMode.Create, FileAccess.Write);
            binaryFormatter.Serialize(fileStream, tvStudenti.Text);
            fileStream.Close();
            tvStudenti.Text = "";
            MessageBox.Show("Binar Export");
        }

        private void exportXml()
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                XmlTextWriter writer = new XmlTextWriter(memoryStream, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                for (int i = 0; i < studentList.Count; i++)
                {
                    writer.WriteStartElement("Student");

                    //cod
                    writer.WriteStartElement("Cod");
                    writer.WriteValue(studentList[i].Cod);
                    writer.WriteEndElement();

                    //nume
                    writer.WriteStartElement("Nume");
                    writer.WriteValue(studentList[i].Nume);
                    writer.WriteEndElement();

                    //varsta
                    writer.WriteStartElement("Varsta");
                    writer.WriteValue(studentList[i].Varsta);
                    writer.WriteEndElement();

                    //sex
                    writer.WriteStartElement("Sex");
                    writer.WriteValue(studentList[i].Sex);
                    writer.WriteEndElement();

                    //an
                    writer.WriteStartElement("An");
                    writer.WriteValue(studentList[i].An);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Materii");
                    for (int j = 0; j < studentList[i].MateriiList.Count; j++)
                    {
                        writer.WriteStartElement("Materie");

                        writer.WriteStartElement("Denumire");
                        writer.WriteValue(studentList[i].MateriiList[j].Denumire);
                        writer.WriteEndElement();

                        writer.WriteStartElement("Nota");
                        writer.WriteValue(studentList[i].MateriiList[j].Nota);
                        writer.WriteEndElement();

                        writer.WriteStartElement("Credite");
                        writer.WriteValue(studentList[i].MateriiList[j].Credite);
                        writer.WriteEndElement();

                        writer.WriteStartElement("TipExamen");
                        writer.WriteValue(studentList[i].MateriiList[j].TipExamen.ToString());
                        writer.WriteEndElement();

                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement(); //materii
                    //nr credite
                    writer.WriteStartElement("NrCredite");
                    writer.WriteValue(studentList[i].CrediteTotale);
                    writer.WriteEndElement();

                    //media generala
                    writer.WriteStartElement("Medie");
                    writer.WriteValue(studentList[i].Medie);
                    writer.WriteEndElement();

                    //finantare
                    writer.WriteStartElement("TipFinantare");
                    writer.WriteValue(studentList[i].Finantare.ToString());
                    writer.WriteEndElement();
                    
                    writer.WriteEndElement();

                    writer.WriteWhitespace("\n\n");
                }

                writer.WriteEndDocument();

                MessageBox.Show("Export XML");

                writer.Close();

                string str = Encoding.UTF8.GetString(memoryStream.ToArray());
                memoryStream.Close();
                StreamWriter streamWriter = new StreamWriter("fisierXml.xml");
                streamWriter.WriteLine(str);
                streamWriter.Close();
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Nu s-a putut exporta Xml!!!");
            }
        }

        #endregion

        #region importuri

        private void importText()
        {
            //todo import text
        }

        private void importBinar()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("fisier.dat",
                FileMode.Open, FileAccess.Read);
            //cast catre string pt ca returneaza un obj
            tvStudenti.Text = (string) binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            MessageBox.Show("Binar Import");
        }

        private void importXml()
        {
            try
            {
                List<Student> studentListXml = new List<Student>();

                //todo import xml 
                StreamReader streamReader = new StreamReader("fisierXml.xml");
                string str = streamReader.ReadToEnd();
                streamReader.Close();
                XmlReader reader = XmlReader.Create(new StringReader(str));

                while (reader.Read())
                    if (reader.Name == "Student" && reader.NodeType == XmlNodeType.Element)
                    {
                        int cod = 0;
                        string nume = "";
                        int varsta = 0;
                        string sex = "";
                        int an = 0;
                        List<Materie> materiiListXml = new List<Materie>();

                        while (reader.Read())
                        {
                            if (reader.Name == "Cod" && reader.NodeType == XmlNodeType.Element)
                            {
                                reader.Read();
                                cod = Convert.ToInt32(reader.Value);
                            }

                            if (reader.Name == "Nume" && reader.NodeType == XmlNodeType.Element)
                            {
                                reader.Read();
                                nume = reader.Value;
                            }

                            if (reader.Name == "Varsta" && reader.NodeType == XmlNodeType.Element)
                            {
                                reader.Read();
                                varsta = Convert.ToInt32(reader.Value);
                            }

                            if (reader.Name == "Sex" && reader.NodeType == XmlNodeType.Element)
                            {
                                reader.Read();
                                sex = reader.Value;
                            }

                            if (reader.Name == "An" && reader.NodeType == XmlNodeType.Element)
                            {
                                reader.Read();
                                an = Convert.ToInt32(reader.Value);
                            }

                            if (reader.Name == "Materie" && reader.NodeType == XmlNodeType.Element)
                            {
                                string denumire = "";
                                int nota = 0;
                                int credite = 0;

                                if (reader.Name == "Denumire" && reader.NodeType == XmlNodeType.Element)
                                {
                                    reader.Read();
                                    denumire = reader.Value;
                                }

                                if (reader.Name == "Nota" && reader.NodeType == XmlNodeType.Element)
                                {
                                    reader.Read();
                                    nota = Convert.ToInt32(reader.Value);
                                }

                                if (reader.Name == "Credite" && reader.NodeType == XmlNodeType.Element)
                                {
                                    reader.Read();
                                    credite = Convert.ToInt32(reader.Value);
                                }

                                Materie materie = new Materie(denumire, credite, nota);
                                materiiListXml.Add(materie);
                                Console.WriteLine("materie");
                            }

                            if (cod != 0)
                            {
                                Student student = new Student(cod, nume, varsta, sex, an, materiiListXml);
                                studentListXml.Add(student);
                                Console.WriteLine("student");
                            }
                        }
                    }

                reader.Close();
                tvStudenti.Nodes.Clear();
                TreeNode parinte = new TreeNode("Studenti");
                tvStudenti.Nodes.Add(parinte);

                foreach (Student student in studentListXml)
                {
                    TreeNode nodCod = new TreeNode(student.Cod.ToString());

                    TreeNode nodNume = new TreeNode(student.Nume);
                    TreeNode nodVarsta = new TreeNode(student.Varsta.ToString());
                    TreeNode nodSex = new TreeNode(student.Sex);
                    TreeNode nodAn = new TreeNode(student.An.ToString());
                    TreeNode nodMaterii = new TreeNode("Materii(" + student.MateriiList.Count + ")");

                    for (int i = 0; i < student.MateriiList.Count; i++)
                    {
                        TreeNode nodMaterie = new TreeNode(student.MateriiList[i].Denumire);

                        TreeNode nodCredit = new TreeNode(student.MateriiList[i].Credite.ToString());
                        TreeNode nodNota = new TreeNode(student.MateriiList[i].Nota.ToString());
                        TreeNode nodTip = new TreeNode(student.MateriiList[i].TipExamen.ToString());

                        nodMaterie.Nodes.Add(nodCredit);
                        nodMaterie.Nodes.Add(nodNota);
                        nodMaterie.Nodes.Add(nodTip);

                        nodMaterii.Nodes.Add(nodMaterie);
                    }

                    nodCod.Nodes.Add(nodNume);
                    nodCod.Nodes.Add(nodVarsta);
                    nodCod.Nodes.Add(nodSex);
                    nodCod.Nodes.Add(nodAn);
                    nodCod.Nodes.Add(nodMaterii);

                    parinte.Nodes.Add(nodCod);
                }

                tvStudenti.ExpandAll();
                MessageBox.Show("Import Xml");
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region shortcuts

        #endregion
    }
}