using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGame.Tests
{
    [TestClass()]
    public class ScoreboardTests
    {
        [TestMethod()]
        public void getTermTest_loveAll()
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.Point1 = "0";
            scoreboard.Point2 = "0";
            string term = scoreboard.getTerm();
            Assert.AreEqual("Love All", term);
        }
        [TestMethod()]
        public void getTermTest_fifteenLove()
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.Point1 = "1";
            scoreboard.Point2 = "0";
            string term = scoreboard.getTerm();
            Assert.AreEqual("Fifteen Love", term);
        }
    }
}