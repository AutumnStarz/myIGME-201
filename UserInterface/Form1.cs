using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.passwordButton.Click += new EventHandler(this.PasswordButton__Click);
            this.loginButton.Click += new EventHandler(this.LoginButton__Click);

            this.loginButton2.Hide();
        }

        private void PasswordButton__Click(object sender, EventArgs e)
        {

        }

        private void LoginButton__Click(Object sender, EventArgs e)
        {
            this.passwordButton.Enabled = false;
            MessageBox.Show("Incorrect Password. Please try again.");
            this.loginButton.Hide();
            this.loginButton2.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
