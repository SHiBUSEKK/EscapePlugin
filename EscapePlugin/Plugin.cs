using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

namespace EscapePlugin
{
    public class EscapePlugin : Plugin<Config>
    {
        public override string Name => "EscapePlugin";
        public override string Author => "TheSheosi, Shibusekk";
        public override Version Version => new Version(1, 0, 1);
        public override Version RequiredExiledVersion => new Version(9, 6, 1);

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Escaping += OnEscaping;
            Log.Info("EscapePlugin has been enabled. Thank you for using our plugin.");
        }

        private void OnEscaping(EscapingEventArgs ev)
        {
            ev.NewRole = RoleTypeId.Spectator;
        }
    }
}
