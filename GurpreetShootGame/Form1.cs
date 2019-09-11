using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GurpreetShootGame
{
    public partial class Form1 : Form
    {
        int y = 0,shoot=0,chance=0,shootawaychance=0;
        fireGame objct=new fireGame();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // this timer method is used to Blink the label on the window with using timer
            y++;
            if (y==1) {
                label1.Visible = false;
            }
            else {
                label1.Visible = true;
                y = 0;
            }
        }

        private void starting_Click(object sender, EventArgs e)
        {
            //here we are calling the method of the start game in which we have pass the object 
            objct.StartGame(gunBox);
        }

        private void TryAgain_Click(object sender, EventArgs e)
        {
            //this code is used to try again the game and reload the whole concept 
            shoot = 0;
            chance = 0;
            shootawaychance = 0;
            Shoot.Enabled = true;
            Firing.Enabled = true;
            //calling the starting game method of the class that is working in the another class
            objct.StartGame(gunBox);
        }

        private void Shoot_Click(object sender, EventArgs e)
        {

                shootawaychance++;   
             //this code is used to generate the sound effect when the trigger is accurate 
             using (var soundPlayer = new SoundPlayer(@"fire.wav"))
             {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
             }

             //find the winner on clicking the shoot away button 
            if (objct.findWinner(shootawaychance)=="Winner") {
                MessageBox.Show("You are the winner of  the game ");
            }
            // this will display  the 2nd chance is over 
            if (shootawaychance==2) {
                MessageBox.Show("Sorry your all chances are over now try again");
                objct.disble(Shoot);
            }

        }

        private void Loading_Click(object sender, EventArgs e)
        {
            //here we are calling the method of the Load game in which we have pass the object 
            objct.loadGame(gunBox);
        }
        
        private void Firing_Click(object sender, EventArgs e)
        {
            //here we are calling the method of the fire game in which we have pass the object 
            objct.FireGame(gunBox);
            shoot++;
            //this is used to compare the value of the 
            if (objct.fireSound()==shoot) {
                //this code is used to generate the sound effect when the trigger is accurate 
                using (var soundPlayer = new SoundPlayer(@"fire.wav"))
                {
                    soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                }
                // this code is used to find the winner 
                chance++;
                if (objct.findWinner(shoot) == "winner")
                {
                    MessageBox.Show("You won the Game ");
                    objct.disble(Firing);
                }
                //display the first chance is over
                else if(chance==1){
                    MessageBox.Show("You Loos the Game this is ur last chance");
                }
                //when the game is over 
                if (chance==2) {
                    MessageBox.Show("You Loos the Game ");
                    objct.disble(Firing);
                }
            }
            // reset the first chance 
            if (shoot == 6 && chance<=1) {
                shoot = 0;
            }
        }

        

    }
}
