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
            Scoreboard scoreboard = new Scoreboard();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Enter point of Joey:");
                scoreboard.Point1 = Console.ReadLine();
                Console.WriteLine("Enter point of Tom:");
                scoreboard.Point2 = Console.ReadLine();

                Console.WriteLine(scoreboard.getTerm() + "\n");
            }
        }
    }

    public class Scoreboard
    {
        private string point1 = "";
        private string point2 = "";

        private Dictionary<string, string> termMap = new Dictionary<string, string>();

        public string Point1
        {
            set { this.point1 = value; }
        }
        public string Point2
        {
            set { this.point2 = value; }
        }

        public Scoreboard()
        {
            this.point1 = "";
            this.point2 = "";
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
        public string getTerm()
        {
            string term = "";
            string scores = string.Concat(this.point1, this.point2);
            if (termMap.TryGetValue(scores, out term))
            { } else {
                term = "Please key the correct scores in.";
            }

            return term;
        }
    }
}
