using System;
using System.Collections.Generic;
using Xunit;
using HeroGameAdvancedLib;

namespace HeroGameAdvancedTests {
    public class HeroTests {
        [Theory]
        [InlineData(3,1,2)]
        [InlineData(2,1,1)]
        [InlineData(1,1,0)]
        // timesToAttack is greater that the number of Uses should return -1 and not subtract from Uses.
        [InlineData(1,2,-1)]
        public void AttackTest(int uses, int timesToAttack, int expected) {
            Dice d = new Dice(1,6);

            Hero h = new Hero(1, "Poopy", d, uses);
            h.Attack(timesToAttack);
            int result = h.Uses;

            Assert.Equal(expected, result);
        }
    }
}
