using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_and_Scissors_Game
{
    public partial class Form1 : Form
    {

        int rounds = 3;
        int timerPerRound = 6;
        bool gameOver = false;
        // uses Random for the AI choices added multiple answers in array to give me variety to the rng
        string[] AIChoiceList = {"rock","paper","scissor","paper","scissor","rock" };   
        int randomNumber = 0;
        Random rng = new Random();

        string AIChoice;
        string playerChoice;

        int AIScore;
        int playerScore;

        public Form1()
        {
            InitializeComponent();

            countDowntimer.Enabled = true;

            playerChoice = "none";

            lblCountdown.Text = "5";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            pbxPlayer.Image = Properties.Resources.rock;
            playerChoice = "rock";


        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            pbxPlayer.Image = Properties.Resources.paper;
            playerChoice = "paper";

        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            pbxPlayer.Image = Properties.Resources.scissors;
            playerChoice = "scissor";

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            AIScore = 0;
            rounds = 3;
            lblscore.Text = "Player: " + playerScore + " - " + "AI " + AIScore;

            playerChoice = "none";

            countDowntimer.Enabled = true;

            pbxPlayer.Image = Properties.Resources.question;
            pbxAI.Image = Properties.Resources.question;

            gameOver = false;


        }

        private void countDowntimerEvent(object sender, EventArgs e)
        {
            timerPerRound -= 1;
            lblCountdown.Text = timerPerRound.ToString();

            lblRounds.Text = "Rounds:" + rounds; 

            if(timerPerRound < 1)
            {
                countDowntimer.Enabled = false;

                timerPerRound = 6;

                randomNumber = rng.Next(0, AIChoiceList.Length);

                AIChoice = AIChoiceList[randomNumber];

                switch(AIChoice)
                {
                    case "rock":
                        pbxAI.Image = Properties.Resources.rock;

                        break;
                    case "paper":
                        pbxAI.Image = Properties.Resources.paper;

                        break;
                    case "scissor":
                        pbxAI.Image = Properties.Resources.scissors;

                        break;

                }

                if (rounds > 1)
                {
                    checkGame();
                }
                else
                {
                    if (playerScore > AIScore)
                    {
                        MessageBox.Show("playerScore Won the game");
                    }
                    else
                    {
                        MessageBox.Show("AI Won the game");
                    }

                    gameOver = true;
                }
                    

            }

 

        }
        private void checkGame()
        {
            // if statement to find who wins and give them a point
            if(playerChoice == "rock" && AIChoice == "paper")
            {
                AIScore += 1;

                rounds -= 1;

                MessageBox.Show("AI Wins Paper Covers Rock");
            }
          else if (playerChoice == "scissor" && AIChoice == "rock")
            {
                AIScore += 1;

                rounds -= 1;

                MessageBox.Show("AI Wins Rock Breaks Scissor");
            }
          else if (playerChoice == "paper" && AIChoice == "scissor")
            {
                AIScore += 1;

                rounds -= 1;

                MessageBox.Show("AI Wins scissor cuts paper");
            }
           else if (playerChoice == "rock" && AIChoice == "scissor")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins Rock Breaks Scissor");
            }
            else if (playerChoice == "paper" && AIChoice == "rock")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins Paper Covers Rock");
            }
            else if (playerChoice == "scissor" && AIChoice == "paper")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins scissor cuts paper");
            }
            else if (playerChoice == "none")
            {
                MessageBox.Show("Make A choice");
            }
            else
            {
                MessageBox.Show("Draw");
            }
            startNextRound();
        }

        private void startNextRound()
        {

            if(gameOver == true)
            {
                return;
            }


            lblscore.Text = "Player: " + playerScore + " - " + "AI " + AIScore;

            playerChoice = "none";

            countDowntimer.Enabled = true;

            pbxPlayer.Image = Properties.Resources.question;
            pbxAI.Image = Properties.Resources.question;
        }

    }
}
