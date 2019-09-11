using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GurpreetShootGame
{
   public class fireGame
    {
        Random rd = new Random();
        int winner = 0;
        //in this method i have passed the picturebox as object to the method so we can pass the value 
        public void StartGame(PictureBox p)
        {
            p.ImageLocation = "start.jpg";
        }
        public void loadGame(PictureBox pb)
        {
            pb.ImageLocation = "Load.jpg";
        }
        public void FireGame(PictureBox pb)
        {
            pb.ImageLocation = "Fire.jpg";
        }
        //this method is used to generate the random and also sound of fire
        public int fireSound() {
            winner=rd.Next(1, 6);
            return winner;
        }

        //this method is used to find the winner or looser from the shoot game 
        public String findWinner(int s) {
            if (winner == s)
            {
                return "Winner";
            }
            else {
                return "Looser";
            }
        }
        // this  method  is used to disable the button after wining the game 
        public void disble(Button b) {
            b.Enabled = false;
        }
    }
}
