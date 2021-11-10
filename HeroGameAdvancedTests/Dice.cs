using System;
using System.Collections.Generic;
using Xunit;
using HeroGameAdvancedLib;

namespace HeroGameAdvancedTests {
    public class DiceTests {
        [Fact]
        public void DiceTest1() {
            Dice d = new Dice(1, 6);

            int diceRoll = d.Roll();

            Assert.InRange(diceRoll,1,6);

        }

        /*
        [Fact]
        public void DiceTest2() {
            Dice d2 = new Dice(1, 6);

            int diceRoll = d2.Roll();

            // One will fail and the other will pass, as it isn't within the ranges of each
            Assert.InRange(diceRoll, 1,3);
            Assert.InRange(diceRoll,3,6);

            // Will always fail as it isn't in range
            Assert.InRange(diceRoll,6,9);       
            Assert.InRange(diceRoll,0,0);         
            
        }
        */
    }
}
