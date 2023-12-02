using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceFromHell
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            this.ControlBox = false;

            Thread colorChangeThread = new Thread(ChangeFormColor);
            colorChangeThread.Start();

            this.logoutButton.Click += new EventHandler(this.LogoutButton__Click);
        }

        private void LogoutButton__Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully logged out! :)");
            this.Close();
        }

        //create thread that makes the background color randomly
        private void ChangeFormColor()
        {
            Random random = new Random();

            while (true)
            {
                Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
     
                this.Invoke((MethodInvoker)delegate
                {
                    this.BackColor = randomColor;
                });

                Thread.Sleep(1000);
            }
        }


        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass1_Click(object sender, EventArgs e)
        {

        }

        private void user1_Click(object sender, EventArgs e)
        {

        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordButton_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
