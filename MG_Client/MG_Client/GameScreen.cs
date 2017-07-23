using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MG_Client
{
    public partial class GameScreen : Form
    {
        private Card firstClicked;
        private Card secondClicked;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer checkMessagesTimer;
        private System.Windows.Forms.Timer turnTimer;

        private int currentTime;
        private int timeLimit;
        private bool turn;
        public int gameID;

        private bool cardWon;
        private int p1Score;
        private int p2Score;
        private Client opponent;
        private Messages.MESSAGE msg;
        private static Network TCP { get; set; }
        GSMessages sessionDecoder; 
        public GameScreen(Client opponent, string seed, bool initialTurn, int gameID)
        {
            InitializeComponent();
            p1Score = 0;
            p2Score = 0;
            cardWon = false;
            this.opponent = opponent;
            lb_playingAgainst.Text = "You're playing against: " + opponent.Alias;
            timeLimit = 30;
            this.turn = initialTurn;

            TCP = Network.getNetwork();
            sessionDecoder = new GSMessages(gameID);

            //Timer for hiding cards 
            timer = new Timer();
            timer.Tick += new EventHandler(hideCards);
            timer.Interval = 1000;
            timer.Enabled = false;
            //Timer for checking recived messages 
            checkMessagesTimer = new Timer();
            checkMessagesTimer.Tick += new EventHandler(recMessages);
            checkMessagesTimer.Interval = 100;
            checkMessagesTimer.Enabled = true;
            //Timer for calculating remaining turn for each player 
            turnTimer = new Timer();
            turnTimer.Tick += new EventHandler(turnTimerCheck);
            turnTimer.Interval = 1000;
            turnTimer.Enabled = true;

            char[] icons = seed.ToCharArray();
            int iconIndex = 0;
            //assign random icon to each label card
            foreach (Card item in panel_tableLayout.Controls)
            {
                item.cardID = iconIndex;
                item.Icon = icons[iconIndex].ToString();
                iconIndex++;
            }

            panel_tableLayout.Enabled = false;
            checkMessagesTimer.Start(); //Start checking for recived messages 
            sessionDecoder.playerReady();

        }

        //check for recieved messages 
        private void recMessages(object obj, EventArgs evt)
        {
            
            msg = TCP.receiveMessage();
            switch (msg.msgID)
            {
                case 8:
                    panel_tableLayout.Enabled = turn;
                    turnTimer.Start();
                    break;
            }
        }

        private void turnTimerCheck(object obj, EventArgs evt)
        {
            timeLimit--;
            lb_turnTime.Text = "Time left: " + timeLimit;
            if (timeLimit == 0)
            {
                
                turnTimer.Stop();
                panel_tableLayout.Enabled = false;
                if (turn)
                {
                    //call the server
                }
            }
        }


        private void hideCards(object sender, EventArgs e)
        {
            timer.Stop();
            if (!cardWon && secondClicked != null)
            {
                firstClicked.clickCard();
                secondClicked.clickCard();
            }

            firstClicked = null;
            secondClicked = null;
            cardWon = false;
        }

        private void cardClick(object sender, EventArgs e)
        {
            if (secondClicked == null)
            {
                Card clickedLb = sender as Card;

                //second card clicked 
                if (firstClicked != null)
                {
                    secondClicked = clickedLb;
                    secondClicked.clickCard();

                    if (firstClicked.Icon.Equals(secondClicked.Icon))
                    {
                        Console.WriteLine("CARD WON!");
                        p1Score++;
                        lb_myScore.Text = "Player 1 Score: " + p1Score.ToString();
                        cardWon = true;
                    }
                    else
                    {
                        cardWon = false;
                    }

                    timer.Start();
                }
                else
                {
                    firstClicked = clickedLb;
                    clickedLb.clickCard();
                }
            }
        }


        public void disableTimers()
        {
            turnTimer.Stop();
            turnTimer.Enabled = false;
            checkMessagesTimer.Stop();
            checkMessagesTimer.Enabled = false;
            timer.Stop();
            timer.Enabled = false;
            
        }
    }
}
