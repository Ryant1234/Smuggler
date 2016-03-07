using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        Smuggle MySmuggle = new Smuggle();
      
        public Form1()

        {
            InitializeComponent();
          
        }

   


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnFill_Click(object sender, EventArgs e)
        {

        }

        private void btnApproach_Click(object sender, EventArgs e)
        { // when you click "btnApproach" button  the Approach button is greyed out so you cannot click it again during the game and mess with whats working in the background
       // Also the Cloak button and Smuggle buttons are enabled if they were greyed out due to the player winning or losing the previous game. 
            btnApproach.Enabled = false;
            btnSmuggle.Enabled = true;
            btnCloak.Enabled = true;
            btnNewGame.Enabled = false;
            //The turn that the border guards appear on is set here
            MySmuggle.RandomTurnNumber = MySmuggle.NumberGenerate();
           // The count (turn you are currently one) is set to 0 here as you have not done anything yet
            MySmuggle.Count = 0;
            // Your cloak counter is set to 2 as that is the number of "Cloaks" you have during the game
            MySmuggle.Cloak = 2;
            lblCloak.Text = Convert.ToString(MySmuggle.Cloak);            
            this.Focus();  
            MessageBox.Show("You approach the border area with your goodies");
        }


        private void btnSmuggle_Click(object sender, EventArgs e)
        {
            if (MySmuggle.Cloak >= 1)
            {

                
                btnCloak.Enabled = true;
            }
            MessageBox.Show("You smuggle your contraband across the border");
            MySmuggle.Count++;
           
            // If the count is equal to the turn number that the guard appears on and you have no "Cloaks" left or haven't turned it on
            if ((MySmuggle.Count == MySmuggle.RandomTurnNumber) & (MySmuggle.isCloaked == false))
            {
                MessageBox.Show("The Border Guards appear and shoot you!");
                //The Border Guards appear and shoot you
                
                // A method for sound gets played, then a method stops that sound before playing the next one. Then a messagebox shows up and the Picturebox displays the picture for losing. The " Loss count" goes up and the only option left is to start a new game 
                PlayExplosion();
                SoundStop();
                PlayYouLose();
                MessageBox.Show("You Lose!");           
                pbMain.Image = Resource1.YouLose;
                MySmuggle.LossCount++;
                lblLose.Text = Convert.ToString(MySmuggle.LossCount);
                ButtonDisable();


            }
            // If the count is equal to the turn number that the guards appears on and you have  your cloak activated
            if ((MySmuggle.Count == MySmuggle.RandomTurnNumber) & (MySmuggle.isCloaked == true))
            {
                MessageBox.Show("The Border Guards appear but can not see you!");
                
             // The guards appear but cannot see you, the appropriate messagebox and image are displayed and the sound for winning plays as well 
                MessageBox.Show("You Win!");
                pbMain.Image = Resource1.YouWin;
                PlayYouWin();
               
                MySmuggle.WinCount++;
                lblWin.Text = Convert.ToString(MySmuggle.WinCount);
                ButtonDisable();

            }
            // The "iscloaked" changes to false after everything that happens on this "turn" is executed
            MySmuggle.isCloaked = false;
            if (MySmuggle.Cloak < 1)
            { // If the cloak count is less then 1, the button is greyed out and the condition isCloaked changes to false
                btnCloak.Enabled = false;
                MySmuggle.isCloaked = false;
            }

        }

        private void btnCloak_Click(object sender, EventArgs e)
        {


            // When you click the button "isCloaked" is true and the count goes down by 1 and is sent to the label that holds the "Cloak" count but..      
            SoundStop();
            MySmuggle.isCloaked = true;  
            MySmuggle.Cloak--;
            lblCloak.Text = Convert.ToString(MySmuggle.Cloak);
            // if the cloak count is less then 1
            if (MySmuggle.Cloak < 1)
            {

                // If you have no cloaks left, the cloak button is disabled
                btnCloak.Enabled = false;
            }
            //This disables the button after you click it so you cannot click it twice in a row(if you have 2 clicks in total)
            btnCloak.Enabled = false; 
        }



        private void btnNewGame_Click(object sender, EventArgs e)
        { // When you click the new game button the image changes to the one that is displayed at the beginning, the "Approach" button is enabled and the ButtonDisable method is called
            pbMain.Image = Resource1.SmuggleStart;
            btnApproach.Enabled = true;
            ButtonDisable();
            btnNewGame.Enabled = false;
        }
       public  void ButtonDisable()
        { // This method grays out  the smuggle and cloak button             
            btnSmuggle.Enabled = false;         
              lblCloak.Text = "";
            btnNewGame.Enabled = true;
           btnCloak.Enabled = false;
        }
        // The following methods are for playing sound. 
        public void PlayExplosion()
        {
             SoundPlayer Explosion = new SoundPlayer(Resource1.Explosion); 
            Explosion.Play();
            System.Threading.Thread.Sleep(2000);
        }

        public void PlayYouWin()
        {
            SoundPlayer YouWin = new SoundPlayer(Resource1.YouWin1);
            YouWin.Play();
          
        }

        public void PlayYouLose()
        {
            SoundPlayer YouLose = new SoundPlayer(Resource1.YouLose1);
            YouLose.Play();          
        }

    

        public void SoundStop()
        {
           SoundPlayer Sound = new SoundPlayer();
            Sound.Stop();
        }

        private void pbMain_Click(object sender, EventArgs e)
        {

        }
     

    }
}

