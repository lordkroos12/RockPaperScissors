using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        const string rock = "Rock";
        const string paper = "Paper";
        const string scissors = "Scissors";
        static void Main(string[] args)
        {
            Random random = new Random();
            string playermove = Console.ReadLine();
            string CPUmove = string.Empty;
            int opponent = random.Next(1, 4);
            if (playermove == "rock" || playermove == "Rock")
            {
                playermove = rock;
            }
            else if (playermove == "paper" || playermove == "Paper")
            {
                playermove = paper;
            }
            else if (playermove == "scissors" || playermove == "Scissors")
            {
                playermove = scissors;
            }
            else
            {
                throw new ArgumentException("Invalid input!");
            }
            switch (opponent)
            {
                case 1:
                    CPUmove = rock;
                    break;
                case 2:
                    CPUmove = paper;
                    break;
                case 3:
                    CPUmove = scissors;
                    break;
            }
            Console.WriteLine($"The computer choose {CPUmove}");
            if ((playermove == rock && CPUmove == scissors) || (playermove == paper && CPUmove == rock) || (playermove == scissors && CPUmove == paper))
            {
                Console.WriteLine("You win!");
            }
            else if ((playermove == rock && CPUmove == rock) || (playermove == paper && CPUmove == paper) || (playermove == scissors && CPUmove == scissors))
            {
                Console.WriteLine("Draw!");
            }
            else if ((playermove == scissors && CPUmove == rock) || (playermove == rock && CPUmove == paper) || (playermove == paper && CPUmove == scissors))
            {
                Console.WriteLine("You lose!");
            }
        }
    }
}
