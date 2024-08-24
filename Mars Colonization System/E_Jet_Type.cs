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
    public partial class E_Jet_Type : Form
    {
        public E_Jet_Type()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            E_Jet_Controls ejc2 = new E_Jet_Controls();
            this.Hide();
            ejc2.ShowDialog();

            this.Close();
        }
    }
}
