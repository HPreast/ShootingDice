using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> taunts = new List<string>(4) { "The keys you're looking for are Alt + F4.", "A moment of silence for your E-Sports career.", "I can't hear you from the bottom of the scoreboard.", "With all these flavors why do you choose salt?" };

        public override int Roll()
        {
            int randomTaunt = new Random().Next(0, 3);
            string smackTalk = taunts[randomTaunt];
            Console.WriteLine(smackTalk);
            return base.Roll();
        }
    }
}