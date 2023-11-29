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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.startButton.Click += new EventHandler(this.StartButton__Click); //handle when the start button is pressed
        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            bool bConv;
            int lowNumber = 0;
            int highNumber = 0;

            // convert the strings entered in lowTextBox and highTextBox
            // to lowNumber and highNumber Int32.Parse

            // if not a valid range
            if (!Int32.TryParse(lowTextBox.Text, out lowNumber) || !Int32.TryParse(highTextBox.Text, out highNumber))
            {
                // show a dialog that the numbers are not valid
                MessageBox.Show("The numbers are invalid.");
            }
            else
            {
                // otherwise we're good
                // create a form object of the second form 
                // passing in the number range
                GameForm gameForm = new GameForm(lowNumber, highNumber);

                // display the form as a modal dialog, 
                // which makes the first form inactive
                gameForm.ShowDialog();

                this.Close();
            }
        }


    }
}
