using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp
{
    public partial class Login : Form
    {
        private MyDB myDB = new MyDB();
        public Login()
        {
            InitializeComponent();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txtb_username.Text;
            string password = txtb_password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            try
            {
                bool authenticate = myDB.RecExist("admin", "username='" + username + "' AND password='" + password + "'");

                if (authenticate)
                {
                    MessageBox.Show("Login Successfully!");
                    var FrmMain = new Form1();
                    FrmMain.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

    }
}
