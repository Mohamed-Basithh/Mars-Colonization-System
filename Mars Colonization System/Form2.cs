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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Colonist_Register cr2 = new Colonist_Register();
            this.Hide();
            cr2.ShowDialog();

            this.Close();


        }

        private void btntripscheduling_Click(object sender, EventArgs e)
        {
            Trip_Scheduling TS2 = new Trip_Scheduling();
            this.Hide();
            TS2.ShowDialog();

            this.Close();
        }

        private void btnpilotoperations_Click(object sender, EventArgs e)
        {
            Pilot_Operators po2 = new Pilot_Operators();
            this.Hide();
            po2.ShowDialog();

            this.Close();
        }

        private void btnejetcontrols_Click(object sender, EventArgs e)
        {
            E_Jet_Controls EJC2 = new E_Jet_Controls();
            this.Hide();
            EJC2.ShowDialog();

            this.Close();
        }

        private void btnhomemanagement_Click(object sender, EventArgs e)
        {
            Home_Management hm2 = new Home_Management();
            this.Hide();
            hm2.ShowDialog();

            this.Close();
        }

        private void btnjobmanagement_Click(object sender, EventArgs e)
        {
            Job_Management jm2 = new Job_Management();
            this.Hide();
            jm2.ShowDialog();

            this.Close();
        }
    }
}
