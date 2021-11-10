using System;
using Xunit;
using HeroGameAdvancedLib;

namespace HeroGameAdvancedTests {
    public class VillainTests {
        [Theory]
        [InlineData(10,5,5)]
        [InlineData(5,3,2)]
        [InlineData(2,1,1)]
        [InlineData(1,5,0)]
        
        public void HPTest(int HP, int dmg, int expected) {
            Villain v = new Villain(1, "Farty McFart Face", HP);

            v.Damage(dmg);
            int result = v.Hitpoints;

            Assert.Equal(expected, result);
        }
    }
}
