using Exiled.API.Features;
using System;
using Server = Exiled.Events.Handlers.Server;

namespace CI_Replacer
{
    public class Main : Plugin<Config>
    {
        EventHandlers EventHandler = new EventHandlers();

        public override void OnEnabled()
        {
            base.OnEnabled();
            EventHandler = new EventHandlers();
            Server.RoundStarted += EventHandler.RoundStart;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            EventHandler = null;
            Server.RoundStarted -= EventHandler.RoundStart;
        }
    }
}
