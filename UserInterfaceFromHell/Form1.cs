using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceFromHell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //get rid of the controls
            this.ControlBox = false;

            //hide the stuff
            this.BackColor = Color.White;
            this.loginButton2.Hide();
            this.pass2.Hide();
            this.passButton2.Hide();
            this.userBox2.Hide();
            this.user2.Hide();
            this.passBox2.Hide();

            this.loginButton3.Hide();

            this.radioButton1.Hide();
            this.radioButton2.Hide();
            this.radioButton3.Hide();
            this.radioButton4.Hide();

            this.pickLabel.Hide();

            //set up event handlers
            this.loginButton.Click += new EventHandler(this.LoginButton__Click);
            this.loginButton2.Click += new EventHandler(this.LoginButton2__Click);
            this.loginButton3.Click += new EventHandler(this.LoginButton3__Click);

            this.radioButton1.Click += new EventHandler(this.RadioButton1__Click);

            this.passwordButton.Click += new EventHandler(this.passwordButton__Click);

            this.passButton2.Click += new EventHandler(this.passButton2__Click);

        }

        private void passButton2__Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
        }

        private void passwordButton__Click(object sender, EventArgs e)
        {
            string imageUrl = "https://i.kym-cdn.com/entries/icons/facebook/000/046/895/huh_cat.jpg";
            pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
        }

        private void RadioButton1__Click(object sender, EventArgs e)
        {
            this.loginButton.Show();
            this.user1.Show();
            this.pass1.Show();
            this.passwordButton.Show();
            this.userBox.Show();
            this.passBox.Show();

            this.radioButton1.Hide();
            this.radioButton2.Hide();
            this.radioButton3.Hide();
            this.radioButton4.Hide();

            this.BackColor = Color.White;
            MessageBox.Show("Welcome back! Please login.");
            this.pickLabel.Hide();
            //pictureBox1.Show();
        }

        private void LoginButton3__Click(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink;
            MessageBox.Show("Error");
            this.loginButton3.Hide();

            this.radioButton1.Show();
            this.radioButton2.Show();
            this.radioButton3.Show();
            this.radioButton4.Show();
            this.pickLabel.Show();


        }

        private void LoginButton__Click(object sender, EventArgs e)
        {
            MessageBox.Show("An error has occurred please try again.");
            this.loginButton.Hide();
            this.loginButton2.Show();
            this.user1.Hide();
            this.pass1.Hide();
            this.passwordButton.Hide();
            this.userBox.Hide();
            this.passBox.Hide();
            this.pictureBox1.Hide();

            this.loginButton2.Show();
            this.pass2.Show();
            this.passButton2.Show();
            this.userBox2.Show();
            this.user2.Show();
            this.passBox2.Show();
            this.BackColor = Color.Green;
        }

        private void LoginButton2__Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error occurred.");
            this.BackColor = Color.Blue;
            this.loginButton2.Hide();
            this.pass2.Hide();
            this.passButton2.Hide();
            this.userBox2.Hide();
            this.user2.Hide();
            this.passBox2.Hide();

            this.loginButton3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void passwordButton_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
