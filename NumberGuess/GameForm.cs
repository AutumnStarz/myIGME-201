using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuess
{
    public partial class GameForm : Form
    {
        public int lowNumber;
        public int highNumber;
        public int correctNumber;
        public int timerCountdown = 45; //set the coutdown to 45
       
        public GameForm(int low, int high)
        {
            InitializeComponent();
            //set the low and high nums
            this.lowNumber = low;
            this.highNumber = high;

            //create the random number
            Random random = new Random();
            correctNumber = random.Next(lowNumber, highNumber + 1);

            //actually make the timer a timer
            this.timer1 = new Timer();
            this.timer1.Interval = 1000; 
            this.timer1.Tick += Timer_Tick;
            this.timer1.Start();
           
            outputLabel.Visible = false; //make invisble for now

            this.guessButton.Click += new EventHandler(this.guessButton__Click);

        }

        private void guessButton__Click(object sender, EventArgs e)
        {
            if (int.TryParse(guessTextBox.Text, out int guess)) //make sure the user actually entered a number
            {
                if (guess == correctNumber) //if their guess matched the generated number
                {
                    MessageBox.Show("Yay, you got it correct!");
                    this.Close();
                }
                else if (guess < correctNumber)
                {
                    outputLabel.Text = "Too low!";
                }
                else
                {
                    outputLabel.Text = "Too high!";
                }

                outputLabel.Visible = true; //make it visble now

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //handles the timer 

            timerCountdown--;

            if (timerCountdown <= 0) //see if its reached 0
            {
                this.timer1.Stop(); //stop it once its reached 0
                this.outputLabel.Text = "Your time is up!";
                this.outputLabel.Visible = true;

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
