using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override int Roll()
        {
            int upperHalf = new Random().Next(3, 6);
            return upperHalf;
        }
        public override void Play(Player other)
        {
            int myRoll = Roll();
            int otherRoll = other.Roll();

            if (otherRoll >= myRoll)
            {
                throw new Exception("You really thought I'd let you win?");
            }
            else
            {
                Console.WriteLine($"{Name} rolls a {myRoll}");
                Console.WriteLine($"{other.Name} rolls a {otherRoll}");
                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                }
                else if (myRoll < otherRoll)
                {
                    Console.WriteLine($"{other.Name} Wins!");
                }
                else
                {
                    // if the rolls are equal it's a tie
                    Console.WriteLine("It's a tie");
                }
            }
        }
    }
}