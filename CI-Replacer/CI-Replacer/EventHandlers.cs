using Player = Exiled.API.Features.Player;
using System;

namespace CI_Replacer
{
    class EventHandlers
    {
        public void RoundStart()
        {
            Random random = new Random();
            int chance = random.Next(1, 100);
            if (chance <= Config.ReplacementChancePercent)
            {
                foreach (Player player in Player.List)
                {
                    if (player.Role == RoleType.FacilityGuard)
                    {
                        player.SetRole(RoleType.ChaosRifleman);
                    }
                }
            }
        }
    }
}
