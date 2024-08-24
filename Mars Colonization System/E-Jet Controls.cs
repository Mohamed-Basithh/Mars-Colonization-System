using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mars_Colonization_System
{
    public partial class E_Jet_Controls : Form
    {
        public E_Jet_Controls()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            E_Jet_Type ejt2 = new E_Jet_Type();
            this.Hide();
            ejt2.ShowDialog();

            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();

            this.Close();
        }
    }
}
