using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGame
{
    class Program
    {

        static void Main(string[] args)
        {
            string player = "";
            Scoreboard scoreboard = new Scoreboard();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Who win this ball:");
                player = Console.ReadLine();
                switch (player)
                {
                    case "1":
                        scoreboard.player1GetScore();
                        break;
                    case "2":
                        scoreboard.player2GetScore();
                        break;
                    default:
                        Console.WriteLine("Please key in 1 or 2");
                        break;
                }

                Console.WriteLine(scoreboard.getTerm() + "\n");
            }
        }
    }

    public class Scoreboard
    {
        private string point1 = "";
        private string point2 = "";
        private string term = "";

        private Dictionary<string, string> termMap = new Dictionary<string, string>();

        public void player1GetScore()
        {
            this.point1 = (Int32.Parse(this.point1) + 1).ToString();
            setTerm();
        }
        public void player2GetScore()
        {
            this.point2 = (Int32.Parse(this.point2) + 1).ToString();
            setTerm();
        }

        public Scoreboard()
        {
            this.point1 = "0";
            this.point2 = "0";
            termMap.Add("00", "Love All");
            termMap.Add("10", "Fifteen Love");
            termMap.Add("20", "Thirty Love");
            termMap.Add("30", "Forty Love");
            termMap.Add("01", "Love Fifteen");
            termMap.Add("02", "Love Thirty");
            termMap.Add("11", "Fifteen All");
            termMap.Add("22", "Thirty All");
            termMap.Add("33", "Deuce");
            termMap.Add("43", "Joey Adv");
            termMap.Add("34", "Tom Adv");
            termMap.Add("44", "Deuce");
            termMap.Add("53", "Joey Win");
            termMap.Add("54", "Joey Adv");
        }
        private void setTerm()
        {
            if (this.term != "The game finished")
            {
                string scores = string.Concat(this.point1, this.point2);
                if (termMap.TryGetValue(scores, out this.term))
                { }
                else
                {
                    this.term = "The game finished";
                }
            }
        }
        public string getTerm()
        {
            return this.term;
        }
    }
}
