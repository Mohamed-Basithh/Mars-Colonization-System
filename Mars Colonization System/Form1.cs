using System.Diagnostics.Eventing.Reader;

namespace Mars_Colonization_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            string Username;
            string Password;

            Username=txtusername.Text;
            Password=txtpassword.Text;

            if (Username == "System Admin" && Password == "2005")
            {
                
                Form2 f2 = new Form2(); 
                this.Hide();
                f2.ShowDialog();

                this.Close();
                
            }
            else
            {
                MessageBox.Show("Invalid Login Credential. Please check Username and Password.", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
