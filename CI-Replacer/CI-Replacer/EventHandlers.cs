using Player = Exiled.API.Features.Player;
using System;
using Exiled.API.Features;

namespace CI_Replacer
{
    class EventHandlers
    {
        public void RoundStart() // Hooked to Server.RoundStarted
        {
            Random random = new Random();
            Config config = new Config();
            int chance = random.Next(1, 100);
            if (chance <= config.ReplacementChancePercent) // for example if config.replacementchancepercent = 50 then it's a 50% chance
            {
                foreach (Player player in Player.List) // Iterate through all players
                {
                    if (player.Role == RoleType.FacilityGuard) // If player is a facility guard
                    {
                        player.SetRole(RoleType.ChaosRifleman);  // Change to CI rifleman
                    }
                }
            } else
            {
                Log.Info("No Guards Found");
            }
        }
    }
}
