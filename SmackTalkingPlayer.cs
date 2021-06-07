using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; } = "You were just obliterated. By me.";
        public override int Roll()
        {
            Console.WriteLine($"{Taunt}");
            return base.Roll();
        }
    }
}