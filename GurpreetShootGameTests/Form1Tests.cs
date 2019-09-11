using Microsoft.VisualStudio.TestTools.UnitTesting;
using GurpreetShootGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GurpreetShootGame.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
           // fireGame obj = new fireGame();
           //// obj.findWinner(2);
            //Assert.Fail();
        }

        public void firSoundTest() {
            fireGame obj = new fireGame();
            obj.fireSound();
            Assert.Fail();

        }


    }
}