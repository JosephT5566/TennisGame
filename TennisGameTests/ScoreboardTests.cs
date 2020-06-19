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

            Assert.AreEqual("Love All", scoreboard.getTerm());
        }
        [TestMethod()]
        public void getTermTest_fifteenLove()
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.player1GetScore();

            Assert.AreEqual("Fifteen Love", scoreboard.getTerm());
        }
        [TestMethod()]
        public void getTermTest_fifteenAll()
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.player1GetScore();
            scoreboard.player2GetScore();

            Assert.AreEqual("Fifteen All", scoreboard.getTerm());
        }
        [TestMethod()]
        public void getTermTest_joeyAdv()
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.player1GetScore();
            scoreboard.player1GetScore();
            scoreboard.player1GetScore();
            scoreboard.player2GetScore();
            scoreboard.player2GetScore();
            scoreboard.player2GetScore();
            scoreboard.player1GetScore();

            Assert.AreEqual("Joey Adv", scoreboard.getTerm());
            Assert.AreNotEqual("The game finished", scoreboard.getTerm());
        }
        [TestMethod()]
        public void getTermTest_gameFinished()
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.player1GetScore();
            scoreboard.player1GetScore();
            scoreboard.player1GetScore();
            scoreboard.player1GetScore();

            Assert.AreEqual("The game finished", scoreboard.getTerm());
        }
        [TestMethod()]
        public void getTermTest_gameFinishedAlready()
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.player1GetScore();
            scoreboard.player1GetScore();
            scoreboard.player1GetScore();
            scoreboard.player1GetScore();
            scoreboard.player2GetScore();
            scoreboard.player2GetScore();
            scoreboard.player2GetScore();

            Assert.AreEqual("The game finished", scoreboard.getTerm());
            Assert.AreNotEqual("Joey Adv", scoreboard.getTerm());
        }

    }
}