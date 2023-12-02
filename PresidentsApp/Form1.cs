using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresidentsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //remove the control buttons in the corner
            this.ControlBox = false;

            //start the timer
            timer = new Timer();
            timer.Enabled = true;
            timer.Start();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);

            //code for president radio event handling
            this.radioButtonWashington.CheckedChanged += new EventHandler(this.radioButtonWashington__CheckedChanged);
            this.radioButtonHarrison.CheckedChanged += new EventHandler(this.radioButtonHarrison__CheckedChanged);
            this.radioButtonRoosevelt.CheckedChanged += new EventHandler(this.radioButtonRoosevelt__CheckedChanged);
            this.radioButtonClinton.CheckedChanged += new EventHandler(this.radioButtonClinton__CheckedChanged);
            this.radioButtonBuchanan.CheckedChanged += new EventHandler(this.radioButtonBuchanan__CheckedChanged);
            this.radioButtonPierce.CheckedChanged += new EventHandler(this.radioButtonPierce__CheckedChanged);
            this.radioButtonBush.CheckedChanged += new EventHandler(this.radioButtonBush__CheckedChanged);
            this.radioButtonObama.CheckedChanged += new EventHandler(this.radioButtonObama__CheckedChanged);
            this.radioButtonKennedy.CheckedChanged += new EventHandler(this.radioButtonKennedy__CheckedChanged);
            this.radioButtonMckinley.CheckedChanged += new EventHandler(this.radioButtonMckinley__CheckedChanged);
            this.radioButtonReagan.CheckedChanged += new EventHandler(this.radioButtonReagan__CheckedChanged);
            this.radioButtonEisenhower.CheckedChanged += new EventHandler(this.radioButtonEisenhower__CheckedChanged);
            this.radioButtonVanBuren.CheckedChanged += new EventHandler(this.radioButtonVanBuren__CheckedChanged);
            this.radioButtonAdams.CheckedChanged += new EventHandler(this.radioButtonAdams__CheckedChanged);
            this.radioButtonTRoosevelt.CheckedChanged += new EventHandler(this.radioButtonTRoosevelt__CheckedChanged);
            this.radioButtonJefferson.CheckedChanged += new EventHandler(this.radioButtonJefferson__CheckedChanged);

            //code for filter radio event handling
            this.allButton.CheckedChanged += new EventHandler(this.allButton__CheckedChanged);
            this.democratButton.CheckedChanged += new EventHandler(this.democratButton__CheckedChanged);
            this.republicanButton.CheckedChanged += new EventHandler(this.republicanButton__CheckedChanged);
            this.demorepButton.CheckedChanged += new EventHandler(this.demorepButton__CheckedChanged);
            this.federalistButton.CheckedChanged += new EventHandler(this.federalistButton__CheckedChanged);

            //set as true for default
            this.allButton.Checked = true; 
            this.radioButtonHarrison.Checked = true;

            //code for exit button event handling
            this.exitButton.Click += new EventHandler(this.ExitButton__Click);
            this.exitButton.Visible = false;

            //event handling for text box checked
            this.textBox1.TextChanged += TextBox_TextChanged;
            this.textBox2.TextChanged += TextBox_TextChanged;
            this.textBox3.TextChanged += TextBox_TextChanged;
            this.textBox4.TextChanged += TextBox_TextChanged;
            this.textBox5.TextChanged += TextBox_TextChanged;
            this.textBox6.TextChanged += TextBox_TextChanged;
            this.textBox7.TextChanged += TextBox_TextChanged;
            this.textBox8.TextChanged += TextBox_TextChanged;
            this.textBox9.TextChanged += TextBox_TextChanged;
            this.textBox10.TextChanged += TextBox_TextChanged;
            this.textBox11.TextChanged += TextBox_TextChanged;
            this.textBox12.TextChanged += TextBox_TextChanged;
            this.textBox13.TextChanged += TextBox_TextChanged;
            this.textBox14.TextChanged += TextBox_TextChanged;
            this.textBox15.TextChanged += TextBox_TextChanged;
            this.textBox16.TextChanged += TextBox_TextChanged;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 0)
            {
                progressBar1.Value--;
            }
            else
            {
                timer.Stop();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            //make the exit button invisible until they get all answers right
            this.exitButton.Visible = false;

            if (this.textBox1.Text == "23" && this.textBox2.Text == "32" && this.textBox3.Text == "42" && this.textBox4.Text == "15" && this.textBox5.Text == "14" && this.textBox6.Text == "43" && this.textBox7.Text == "44" && this.textBox8.Text == "35" && this.textBox9.Text == "25" && this.textBox10.Text == "40" && this.textBox11.Text == "34" && this.textBox12.Text == "8" && this.textBox13.Text == "1" && this.textBox14.Text == "2" && this.textBox15.Text == "26" && this.textBox16.Text == "3")
            {
                this.exitButton.Visible = true;
            }

        }

            private void ExitButton__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //check the filter radio
        private void allButton__CheckedChanged(object sender, EventArgs e)
        { 
            if (this.allButton.Checked) { 
            this.radioButtonHarrison.Show();
            this.radioButtonBush.Show();
            this.radioButtonMckinley.Show();
            this.radioButtonReagan.Show();
            this.radioButtonEisenhower.Show();
            this.radioButtonWashington.Show();
            this.radioButtonAdams.Show();
            this.radioButtonTRoosevelt.Show();
            this.radioButtonJefferson.Show();
            this.radioButtonRoosevelt.Show();
            this.radioButtonClinton.Show();
            this.radioButtonBuchanan.Show();
            this.radioButtonPierce.Show();
            this.radioButtonObama.Show();
            this.radioButtonKennedy.Show();
            this.radioButtonVanBuren.Show();
            }
        }
        private void democratButton__CheckedChanged(object sender, EventArgs e)
        {
            if (this.democratButton.Checked)
            {
                this.radioButtonHarrison.Hide();
                this.radioButtonBush.Hide();
                this.radioButtonMckinley.Hide();
                this.radioButtonReagan.Hide();
                this.radioButtonEisenhower.Hide();
                this.radioButtonWashington.Hide();
                this.radioButtonAdams.Hide();
                this.radioButtonTRoosevelt.Hide();
                this.radioButtonJefferson.Hide();

                this.radioButtonRoosevelt.Show();
                this.radioButtonClinton.Show();
                this.radioButtonBuchanan.Show();
                this.radioButtonPierce.Show();
                this.radioButtonObama.Show();
                this.radioButtonKennedy.Show();
                this.radioButtonVanBuren.Show();
            }
        }

        private void republicanButton__CheckedChanged(object sender, EventArgs e)
        {
            if (this.republicanButton.Checked)
            {
                this.radioButtonRoosevelt.Hide();
                this.radioButtonClinton.Hide();
                this.radioButtonBuchanan.Hide();
                this.radioButtonPierce.Hide();
                this.radioButtonObama.Hide();
                this.radioButtonKennedy.Hide();
                this.radioButtonVanBuren.Hide();
                this.radioButtonWashington.Hide();
                this.radioButtonAdams.Hide();
                this.radioButtonJefferson.Hide();

                this.radioButtonHarrison.Show();
                this.radioButtonBush.Show();
                this.radioButtonMckinley.Show();
                this.radioButtonReagan.Show();
                this.radioButtonEisenhower.Show();
                this.radioButtonTRoosevelt.Show();
            }
        }

        private void demorepButton__CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonHarrison.Hide();
            this.radioButtonRoosevelt.Hide();
            this.radioButtonClinton.Hide();
            this.radioButtonBuchanan.Hide();
            this.radioButtonPierce.Hide();
            this.radioButtonBush.Hide();
            this.radioButtonObama.Hide();
            this.radioButtonKennedy.Hide();
            this.radioButtonMckinley.Hide();
            this.radioButtonReagan.Hide();
            this.radioButtonEisenhower.Hide();
            this.radioButtonVanBuren.Hide();
            this.radioButtonWashington.Hide();
            this.radioButtonAdams.Hide();
            this.radioButtonTRoosevelt.Hide();

            this.radioButtonJefferson.Show();
        }

        private void federalistButton__CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonHarrison.Hide();
            this.radioButtonTRoosevelt.Hide();
            this.radioButtonClinton.Hide();
            this.radioButtonBuchanan.Hide();
            this.radioButtonPierce.Hide();
            this.radioButtonBush.Hide();
            this.radioButtonObama.Hide();
            this.radioButtonKennedy.Hide();
            this.radioButtonMckinley.Hide();
            this.radioButtonReagan.Hide();
            this.radioButtonEisenhower.Hide();
            this.radioButtonVanBuren.Hide();
            this.radioButtonRoosevelt.Hide();   
            this.radioButtonJefferson.Hide();


            this.radioButtonWashington.Show();
            this.radioButtonAdams.Show();
        }

        //check the presidents radioes and return teh corresponding wiki page and image
        private void radioButtonWashington__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonWashington.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/George_Washington");
                string imageUrl = "https://people.rit.edu/dxsigm/GeorgeWashington.jpeg";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }

        private void radioButtonHarrison__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonHarrison.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
                string imageUrl = "https://people.rit.edu/dxsigm/BenjaminHarrison.jpeg";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }

        private void radioButtonRoosevelt__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonRoosevelt.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D._Roosevelt");
                string imageUrl = "https://people.rit.edu/dxsigm/FranklinDRoosevelt.jpeg";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }

        private void radioButtonClinton__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonClinton.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Bill_Clinton");
                string imageUrl = "https://people.rit.edu/dxsigm/WilliamJClinton.jpeg";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }

        private void radioButtonBuchanan__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonBuchanan.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/James_Buchanan");
                string imageUrl = "https://people.rit.edu/dxsigm/JamesBuchanan.jpeg";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }

        private void radioButtonPierce__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonPierce.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_Pierce");
                string imageUrl = "https://people.rit.edu/dxsigm/FranklinPierce.jpeg";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }

        private void radioButtonBush__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonBush.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/George_W._Bush");
                string imageUrl = "https://people.rit.edu/dxsigm/GeorgeWBush.jpeg";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }

        private void radioButtonObama__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonObama.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Barack_Obama");
                string imageUrl = "https://people.rit.edu/dxsigm/BarackObama.png";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }

        private void radioButtonKennedy__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonKennedy.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/John_F._Kennedy");
                string imageUrl = "https://people.rit.edu/dxsigm/JohnFKennedy.jpeg";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }

        private void radioButtonMckinley__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonMckinley.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/William_McKinley");
                string imageUrl = "https://people.rit.edu/dxsigm/WilliamMcKinley.jpeg";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }

        private void radioButtonReagan__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonReagan.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Ronald_Reagan");
                string imageUrl = "https://people.rit.edu/dxsigm/RonaldReagan.jpeg";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }

        private void radioButtonEisenhower__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonEisenhower.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Dwight_D._Eisenhower");
                string imageUrl = "https://people.rit.edu/dxsigm/DwightDEisenhower.jpeg";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }

        private void radioButtonVanBuren__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonVanBuren.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Martin_Van_Buren");
                string imageUrl = "https://people.rit.edu/dxsigm/GeorgeWashington.jpeg";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }

        private void radioButtonAdams__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAdams.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/John_Adams");
                string imageUrl = "https://people.rit.edu/dxsigm/JohnAdams.jpeg";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }

        private void radioButtonTRoosevelt__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonTRoosevelt.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");
                string imageUrl = "https://people.rit.edu/dxsigm/TheodoreRoosevelt.jpeg";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }

        private void radioButtonJefferson__CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonJefferson.Checked)
            {
                webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
                string imageUrl = "https://people.rit.edu/dxsigm/ThomasJefferson.jpeg";
                pictureBox1.Image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
            }
        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
