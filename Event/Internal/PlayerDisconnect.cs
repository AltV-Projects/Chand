using AltV.Net;
using AltV.Net.Elements.Entities;

namespace Chand.Event.Internal
{
    public class PlayerDisconnect : IScript
    {
        [ScriptEvent(ScriptEventType.PlayerDisconnect)]
        public void OnPlayerDisconnect(IPlayer player, string reason)
        {
            Alt.Log($"Player {player.Name} disconnected with reason: {reason}");
        }
    }
}
