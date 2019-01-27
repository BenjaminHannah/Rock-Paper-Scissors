using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declare Variables
        int playerChoice = 0;

        private void btnRock_Click(object sender, EventArgs e) //Rock
        {
            playerChoice = 1;
            lblOutput.Text = ("You picked Rock!");
            RunMath();
        }

        private void btnPaper_Click(object sender, EventArgs e) //Paper
        {
            playerChoice = 2;
            lblOutput.Text = ("You picked Paper!");
            RunMath();
        }

        private void btnScissors_Click(object sender, EventArgs e) //Scissors
        {
            playerChoice = 3;
            lblOutput.Text = ("You picked Scissors!");
            RunMath();
        }

        private void RunMath()
        {
            Random ranNumberGenerator = new Random();
            int randomNumber = 1;
            string randomChoice = "Nothing! Something went wrong...";
            randomNumber = ranNumberGenerator.Next(1, 4); //Grab a random number

            //Output the CPU's choice
            if (randomNumber == 1)
            {
                randomChoice = "Rock";
            }
            else if (randomNumber == 2)
            {
                randomChoice = "Paper";
            }
            else if (randomNumber == 3)
            {
                randomChoice = "Scissors";
            }
            else
            {
                randomChoice = "Nothing! Something went wrong...";
            }

            lblOutput2.Text = ("The computer picked " + randomChoice);

            //Figure out who won
            if (playerChoice == randomNumber) //check for ties
            {
                lblOutput3.Text = "It's a Tie!";
            }
            else if (playerChoice == 1) //if player picked rock
            {
                if (randomNumber == 3)
                {
                    lblOutput3.Text = "You Win!";
                }
                else if (randomNumber == 2)
                {
                    lblOutput3.Text = "You Lose!";
                }
            }
            else if (playerChoice == 2) //if player picked paper
            {
                if (randomNumber == 1)
                {
                    lblOutput3.Text = "You Win!";
                }
                else if (randomNumber == 3)
                {
                    lblOutput3.Text = "You Lose!";
                }
            }
            else if (playerChoice == 3) //if player picked scissors
            {
                if (randomNumber == 2)
                {
                    lblOutput3.Text = "You Win!";
                }
                else if (randomNumber == 1)
                {
                    lblOutput3.Text = "You Lose!";
                }
            }
        }
    }
}
