using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballPlayer.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {

        FootballPlayer player = new FootballPlayer() { Id = 1, Name = "a", Age = -1, ShirtNumber = 110 };
        
        [TestMethod()]
        public void ValidateNameTest()
        {
            Assert.ThrowsException<ArgumentException>(() => player.ValidateName());
        }

        [TestMethod()]
        public void ValidateAgeTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ValidateAge());
        }

        [TestMethod()]
        public void ValidateShirtNumberTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ValidateShirtNumber());
        }

    }
}