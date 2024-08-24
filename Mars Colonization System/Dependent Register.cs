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
    public partial class Dependent_Register : Form
    {
        public Dependent_Register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Colonist_Register cr2 = new Colonist_Register();
            this.Hide();
            cr2.ShowDialog();

            this.Close();
        }
    }
}
