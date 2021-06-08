using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Please enter the number you would like to roll between 1 and 6.");
            int humanRoll = Convert.ToInt32(Console.ReadLine());
            return humanRoll;
        }
    }
}