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

namespace RacingGame
{
    public partial class Form1 : Form
    {
        Punter[] myPunter = new Punter[3];
        Thing[] myThing = new Thing[4];
        Race myRace = new Race();

        public Form1()
        {
            InitializeComponent();
            LoadData();
            Transparent();
            ResetGhosts();
            
        }


        private void LoadData()
        {
            for (int i = 0; i < 3; i++)
            {
                myPunter[i] = Factory.GetAPerson(i);
            }

            for (int i = 0; i < 4; i++)
            {
                myThing[i] = Factory.GetAThing(i);
            }


            numThingNumber.Minimum = 1;

            myRace.JoeCash = myPunter[0].cash;
            myRace.AlCash = myPunter[1].cash;
            myRace.BobCash = myPunter[2].cash;
        }

        private void Transparent()
        {

            Application.DoEvents();

            this.PointToScreen(PB1.Location);

            PB1.Parent = pbBackground;

            PB1.BackColor = Color.Transparent;
            //
            this.PointToScreen(PB2.Location);

            PB2.Parent = pbBackground;

            PB2.BackColor = Color.Transparent;

            //
            this.PointToScreen(PB3.Location);

            PB3.Parent = pbBackground;

            PB3.BackColor = Color.Transparent;

            //
            this.PointToScreen(PB4.Location);

            PB4.Parent = pbBackground;

            PB4.BackColor = Color.Transparent;
        }


        private void allBetters_CheckedChanged(object sender, EventArgs e)
        {

            myRace.myRadioButton = (RadioButton) sender;
            if (myRace.myRadioButton.Checked == true)
            {
                int merino = Convert.ToInt16(myRace.myRadioButton.Tag);
                this.Text = myPunter[merino].name;
                txtMaxBet.Text = myPunter[merino].cash.ToString();
                //myPunter[merino].cash = myPunter[merino].cash - 5;


                int cash = myPunter[merino].cash;

                numBetAmount.Text = cash.ToString();
                numBetAmount.Maximum = cash;

            }



        }

      

        private void btnBet_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(myRace.myRadioButton.Tag.ToString());

            int numThingZeroStart = Convert.ToInt16(numThingNumber.Text) - 1;


            int person = Convert.ToInt16(myRace.myRadioButton.Tag);

            if (person == 0)
            {
                lblBetStatus1.Text = "Joe has put $" + numBetAmount.Text + " on thing " +
                                     myThing[numThingZeroStart].thingName;
                myRace.JoeThing = myThing[numThingZeroStart].thingID;
                myRace.JoeBet = true;
                myRace.JoeAmount = Convert.ToInt16(numBetAmount.Text);
                //myRace.JoeAmount = Convert.ToInt16(numBetAmount);
            }
            else if (person == 1)
            {
                lblBetStatus2.Text = "Al has put $" + numBetAmount.Text + " on thing " +
                                     myThing[numThingZeroStart].thingName;
                myRace.AlBet = true;
                myRace.AlThing = myThing[numThingZeroStart].thingID;
                myRace.AlAmount = Convert.ToInt16(numBetAmount.Text);
                //myRace.AlAmount = Convert.ToInt16(numBetAmount);
            }
            else
            {
                lblBetStatus3.Text = "Bob has put $" + numBetAmount.Text + " on thing " +
                                     myThing[numThingZeroStart].thingName;
                myRace.BobBet = true;
                myRace.BobThing = myThing[numThingZeroStart].thingID;
                myRace.BobAmount = Convert.ToInt16(numBetAmount.Text);
                //myRace.BobAmount = Convert.ToInt16(numBetAmount);
            }

        }

        private void Race_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (myRace.JoeBet == true && myRace.AlBet == true && myRace.BobBet == true)
            {
                myRace.TrackLength = Form1.ActiveForm.Width - PB1.Width;


                while (PB1.Location.X < myRace.TrackLength && PB2.Location.X < myRace.TrackLength &&
                       PB3.Location.X < myRace.TrackLength && PB4.Location.X < myRace.TrackLength)

                {
                    PB1.Location = new Point(PB1.Location.X + Factory.Number(), PB1.Location.Y);
                    PB2.Location = new Point(PB2.Location.X + Factory.Number(), PB2.Location.Y);
                    PB3.Location = new Point(PB3.Location.X + Factory.Number(), PB3.Location.Y);
                    PB4.Location = new Point(PB4.Location.X + Factory.Number(), PB4.Location.Y);
                    Application.DoEvents();


                    }
                if (PB1.Location.X >= myRace.TrackLength)
                {
                    MessageBox.Show("The Winner is " + myThing[0].thingName);
                    myRace.Winner = 1;


                }
                else if (PB2.Location.X >= myRace.TrackLength)
                {
                    MessageBox.Show("The Winner is " + myThing[1].thingName);
                    myRace.Winner = 2;

                }
                else if (PB3.Location.X >= myRace.TrackLength)
                {
                    MessageBox.Show("The Winner is " + myThing[2].thingName);
                    myRace.Winner = 3;
                }
                else
                {
                    MessageBox.Show("The Winner is " + myThing[3].thingName);
                    myRace.Winner = 4;
                }

                if (myRace.JoeThing == myRace.Winner)
                {
                    lblBetStatus1.Text = "Joe Wins $" + myRace.JoeAmount;
                    myRace.JoeCash = myRace.JoeCash + myRace.JoeAmount;



                }
                else
                {
                    lblBetStatus1.Text = "Joe Loses $" + myRace.JoeAmount;
                    myRace.JoeCash = myRace.JoeCash - myRace.JoeAmount;
                }
                if (myRace.AlThing == myRace.Winner)
                {
                    lblBetStatus2.Text = "Al Wins $" + myRace.AlAmount;
                    myRace.AlCash = myRace.AlCash + myRace.AlAmount;
                }
                else
                {
                    lblBetStatus2.Text = "Al Loses $" + myRace.AlAmount;
                    myRace.AlCash = myRace.AlCash - myRace.AlAmount;
                }
                if (myRace.BobThing == myRace.Winner)
                {
                    lblBetStatus3.Text = "Bob Wins $" + myRace.BobAmount;
                    myRace.BobCash = myRace.BobCash + myRace.BobAmount;
                }
                else
                {
                    lblBetStatus3.Text = "Bob Loses $" + myRace.BobAmount;
                    myRace.BobCash = myRace.BobCash - myRace.BobAmount;
                }

                myPunter[0].cash = myRace.JoeCash;
                myPunter[1].cash = myRace.AlCash;
                myPunter[2].cash = myRace.BobCash;
                ResetAll();

                if (myRace.BobCash <= 0 && myRace.AlCash <= 0 && myRace.JoeCash <= 0)
                {
                    MessageBox.Show("Everyone is broke. Go Home!");
                    btnBet.Enabled = false;
                    myRace.JoeBet = false;
                }
            }
            else
            {
                MessageBox.Show("Nope");
            }
        }

       


        public void ResetGhosts()
        {
            PB1.Location = new Point(50, 50);
            PB2.Location = new Point(50, 100);
            PB3.Location = new Point(50, 150);
            PB4.Location = new Point(50, 200);

        }

        public void ResetAll()
        {

            ResetGhosts();
           
            if (myRace.JoeCash <= 0)
            {
                joeButton.Enabled = false;
                myRace.JoeBet = true;
                lblBetStatus1.Text = "Busted";
                myRace.BobAmount = 0;
            }
            else
            {
                myRace.JoeBet = false;
            }
            if (myRace.AlCash <= 0)
            {
                alButton.Enabled = false;
                myRace.AlBet = true;
              
                lblBetStatus2.Text = "Busted";
                myRace.AlAmount = 0;
            }
            else
            {
                myRace.AlBet = false;
            }
            if (myRace.BobCash <= 0)
            {
                bobButton.Enabled = false;
                myRace.BobBet = true;
                lblBetStatus3.Text = "Busted";
                myRace.JoeAmount = 0;
            }
            else
            {
                myRace.BobBet = false;
            }

            joeButton.Checked = false;
            alButton.Checked = false;
            bobButton.Checked = false;

        }

       
    }

}
