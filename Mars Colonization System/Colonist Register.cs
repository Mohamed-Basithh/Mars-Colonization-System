using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mars_Colonization_System
{
    public partial class Colonist_Register : Form
    {


        public Colonist_Register()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dependent_Register dr2 = new Dependent_Register();
            this.Hide();
            dr2.ShowDialog();

            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contacts c2 = new Contacts();
            this.Hide();
            c2.ShowDialog();

            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();

            this.Close();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            string ColonistId = txtcolonistid.Text;
            string FirstName = txtfirstname.Text;
            string MiddleName = txtmiddlename.Text;
            string Surename = txtsurname.Text;
            string FamilyMemberCount = txtfamilymembercount.Text;
            string Age = txtage.Text;
            string DateofBirth = txtdateofbirth.Text;
            string Qualifications = txtqualifications.Text;
            string Gender = txtgender.Text;
            string CivilStatus = txtcivilstatus.Text;
            string TripId = txttripid.Text;


            string mysqlconn = "Server= 127.0.0.1;user=System Administrator;database=mars_colonization_db;password=2005";

            string query = $"INSERT INTO colonist (ColonistId, FirstName, MiddleName, Surename, FamilyMemberCount, Age, DateOfBirth, Qualifications, Gender, CivilStatus, TripId) " +
                   $"VALUES ('{ColonistId}', '{FirstName}', '{MiddleName}', '{Surename}', '{FamilyMemberCount}', '{Age}', '{DateofBirth}', '{Qualifications}', '{Gender}', '{CivilStatus}', '{TripId}')";

            using (MySqlConnection conn = new MySqlConnection(mysqlconn))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record inserted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No record was inserted.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }



            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string ColonistId = txtcolonistid.Text;
            string FirstName = txtfirstname.Text;
            string MiddleName = txtmiddlename.Text;
            string Surename = txtsurname.Text;
            string FamilyMemberCount = txtfamilymembercount.Text;
            string Age = txtage.Text;
            string DateofBirth = txtdateofbirth.Text;
            string Qualifications = txtqualifications.Text;
            string Gender = txtgender.Text;
            string CivilStatus = txtcivilstatus.Text;
            string TripId = txttripid.Text;



            string mysqlconn = "Server=127.0.0.1;user=System Administrator;database=mars_colonization_db;password=2005";

            string query = "UPDATE colonist SET FirstName = @FirstName, MiddleName = @MiddleName, Surename = @Surename, " +
                           "FamilyMemberCount = @FamilyMemberCount, Age = @Age, DateOfBirth = @DateOfBirth, Qualifications = @Qualifications, " +
                           "Gender = @Gender, CivilStatus = @CivilStatus, TripId = @TripId WHERE ColonistId = @ColonistId";

            using (MySqlConnection conn = new MySqlConnection(mysqlconn))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ColonistId", ColonistId);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
                    cmd.Parameters.AddWithValue("@Surename", Surename);
                    cmd.Parameters.AddWithValue("@FamilyMemberCount", FamilyMemberCount);
                    cmd.Parameters.AddWithValue("@Age", Age);
                    cmd.Parameters.AddWithValue("@DateOfBirth", DateofBirth);
                    cmd.Parameters.AddWithValue("@Qualifications", Qualifications);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@CivilStatus", CivilStatus);
                    cmd.Parameters.AddWithValue("@TripId", TripId);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Record updated successfully!" : "No record was updated.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchColonistId = txtcolonistid.Text; //sarch using id

            string mysqlconn = "Server=127.0.0.1;user=System Administrator;database=mars_colonization_db;password=2005";
            string query = "SELECT * FROM colonist WHERE ColonistId = @ColonistId";

            using (MySqlConnection conn = new MySqlConnection(mysqlconn))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ColonistId", searchColonistId);

                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                txtfirstname.Text = reader["FirstName"].ToString();
                                txtmiddlename.Text = reader["MiddleName"].ToString();
                                txtsurname.Text = reader["Surename"].ToString();
                                txtfamilymembercount.Text = reader["FamilyMemberCount"].ToString();
                                txtage.Text = reader["Age"].ToString();
                                txtdateofbirth.Text = reader["DateOfBirth"].ToString();
                                txtqualifications.Text = reader["Qualifications"].ToString();
                                txtgender.Text = reader["Gender"].ToString();
                                txtcivilstatus.Text = reader["CivilStatus"].ToString();
                                txttripid.Text = reader["TripId"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No record found.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );


            if (result == DialogResult.Yes)
            {
                string mysqlconn = "Server=127.0.0.1;user=System Administrator;database=mars_colonization_db;password=2005";
                string query = "DELETE FROM colonist WHERE ColonistId = @ColonistId";

                using (MySqlConnection conn = new MySqlConnection(mysqlconn))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@ColonistId", txtcolonistid.Text);

                        try
                        {
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully!");
                            }
                            else
                            {
                                MessageBox.Show("No record was deleted.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }

            }
            else
            {

                MessageBox.Show("Delete operation canceled.");
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcolonistid.Text = "";
            txtfirstname.Text = "";
            txtmiddlename.Text = "";
            txtsurname.Text = "";
            txtfamilymembercount.Text = "";
            txtage.Text = "";
            txtdateofbirth.Text = "";
            txtqualifications.Text = "";
            txtgender.Text = "";
            txtcivilstatus.Text = "";
            txttripid.Text = "";
        }
    }
}
