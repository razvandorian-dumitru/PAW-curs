using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CiureaTest.clase;

namespace CiureaTest
{
    public partial class ListForm : Form
    {
        private List<Student> studentiList;

        public ListForm(List<Student> studentiList)
        {
            InitializeComponent();
            this.studentiList = studentiList;
        }

        private void refresh()
        {
            string rezultat = "";
            for (int i = 0; i < studentiList.Count; i++)
                rezultat += studentiList[i].ToString() + Environment.NewLine;
            tbLista.Text = rezultat;
        }


        private void ListForm_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}