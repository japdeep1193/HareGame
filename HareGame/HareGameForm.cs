using HareGame.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HareGame
{
    public partial class HareGameForm : Form
    {
        Hare[] hares = new Hare[4];
        Player[] players = new Player[3];
        Hare winnerHare;
        Timer[] timers = new Timer[4];
        int endPoint;

        public HareGameForm()
        {
            InitializeComponent();
            GameSettings();
        }

        private void GameSettings()
        {
            endPoint = 40;
            // Hare Details
            PictureBox[] pictures = { pictureHare1, pictureHare2, pictureHare3, pictureHare4 };            
            for(int i = 0; i < pictures.Length; i++)
            {
                hares[i] = new Hare() { Name = "Hare " + (i+1), Picture = pictures[i] };
            }

            // Player Details
            RadioButton[] radios = { playerRadio1, playerRadio2, playerRadio3 };
            TextBox[] texts = { textPlayer1, textPlayer2, textPlayer3 };
            for( int i = 0; i < players.Length; i++)
            {
                players[i] = PlayerFactory.GetInstance(i + 1);
                players[i].Radio = radios[i];
                players[i].TextBox = texts[i];
                players[i].Radio.Text = players[i].Name;
            }
        }


        private void btnAction_Click(object sender, EventArgs e)
        {
            if (btnAction.Text.Contains("Place"))
            {
                int count = 0;
                int total_active = 0;
                foreach (Player player in players)
                {
                    if (!player.Busted())
                    {
                        total_active++;
                        if (player.Radio.Checked)
                        {
                            if (player.Bet == null)
                            {
                                int number = (int)numericHare.Value;
                                int amount = (int)numericBet.Value;
                                bool alreadyPlaced = false;
                                foreach (Player pla in players)
                                {
                                    if (pla.Bet != null && pla.Bet.Hare == hares[number - 1])
                                    {
                                        alreadyPlaced = true;
                                        break;
                                    }
                                }
                                if (alreadyPlaced)
                                {
                                    MessageBox.Show("This Hare is Already Picked in Bet...");
                                }
                                else
                                {
                                    player.Bet = new GameBet() { BetAmount = amount, Hare = hares[number - 1] };
                                }

                            }
                            else
                            {
                                MessageBox.Show("You Already Place Bet for " + player.Name);
                            }
                        }
                        if (player.Bet != null)
                        {
                            count++;
                        }
                    }
                }
                SetDetails();
                if (count == total_active)
                {
                    btnAction.Text = "Begin The Race";
                    panelControls.Enabled = false;
                }
            }
            else if (btnAction.Text.Contains("Begin"))
            {
                for (int index = 0; index < timers.Length; index++)
                {
                    timers[index] = new Timer();
                    timers[index].Interval = 15;
                    timers[index].Tick += Timer_Tick;
                }
                for (int index = 0; index < timers.Length; index++)
                {
                    timers[index].Start();
                }
            }
            else if (btnAction.Text.Contains("End"))
            {
                MessageBox.Show("Game Over!!!");
                Application.Exit();
            }
        }

        private void Timer_Tick(object sender, EventArgs args)
        {
            if (sender is Timer)
            {
                int index = -1;
                Timer timer = sender as Timer;
                for( int i = 0; i < timers.Length; i++)
                {
                    if( timer == timers[i])
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    PictureBox picture = hares[index].Picture;
                    if (picture.Location.X < endPoint)
                    {
                        if (winnerHare == null)
                        {
                            winnerHare = hares[index];
                        }
                        for(int i = 0; i < timers.Length; i++)
                        {
                            timers[i].Stop();
                        }
                    }
                    else
                    {
                        int jump = new Random().Next(1, 15);
                        picture.Location = new Point(picture.Location.X - jump, picture.Location.Y);
                    }
                }
            }
            if (winnerHare != null)
            {
                MessageBox.Show("Hurray!!! " + winnerHare.Name + " is Won...");
                SetDetails();
                foreach (Player player in players)
                {
                    if (player.Bet != null)
                    {
                        if (player.Bet.Hare == winnerHare)
                        {
                            player.Amount += player.Bet.BetAmount;
                            player.TextBox.Text = player.Name + " Won and now has $" + player.Amount;                            
                        }
                        else
                        {
                            player.Amount -= player.Bet.BetAmount;
                            if (player.Amount == 0)
                            {
                                player.TextBox.Text = "BUSTED!!!";                                
                                player.Radio.Enabled = false;
                            }
                            else
                            {
                                player.TextBox.Text = player.Name + " Lost and now has $" + player.Amount;
                            }
                        }
                    }
                }
                winnerHare = null;
                for(int i =0; i < timers.Length; i++)
                {
                    timers[i] = null;
                }
                int count = 0;
                foreach (Player player in players)
                {
                    if (player.Busted())
                    {
                        count++;
                    }
                    if (player.Radio.Enabled && player.Radio.Checked)
                    {
                        labelMaxBet.Text = player.Name + " Max Bet is $" + player.Amount;
                        numericBet.Maximum = player.Amount;
                        numericBet.Minimum = 1;
                    }
                    player.Bet = null;                    
                }
                if (count == players.Length)
                {
                    btnAction.Text = "End Game";

                }
                else
                {
                    panelControls.Enabled = true;
                }
                foreach (Hare hare in hares)
                {
                    hare.Picture.Location = new Point(810, hare.Picture.Location.Y);
                }
            }
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            SetDetails();
        }

        private void SetDetails()
        {
            foreach (Player player in players)
            {
                if (player.Busted())
                {
                    player.TextBox.Text = "BUSTED!!!";
                }
                else
                {
                    if (player.Bet == null)
                    {
                        player.TextBox.Text = player.Name + " hasn't placed a bet";
                    }
                    else
                    {
                        player.TextBox.Text = player.Name + " bets $" + player.Bet.BetAmount + " on " + player.Bet.Hare.Name;
                    }
                    if (player.Radio.Checked)
                    {
                        labelMaxBet.Text = player.Name + " Max Bet Amount is $" + player.Amount.ToString();
                        btnAction.Text = "Place Bet for " + player.Name;
                        labelBet.Text = player.Name + " Bet Amount is $";
                        labelHare.Text = player.Name + " Bet on Hare No";
                        numericBet.Maximum = player.Amount;
                        numericBet.Value = 1;
                    }
                }
            }
        }

        private void labelHare_Click(object sender, EventArgs e)
        {

        }

        private void HareGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
