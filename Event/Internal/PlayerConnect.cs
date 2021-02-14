using AltV.Net;
using AltV.Net.Elements.Entities;

namespace Chand.Event.Internal
{
    public class PlayerConnect : IScript
    {
        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public void OnPlayerConnect(IPlayer player, string reason)
        {
            Alt.Log($"Player {player.Name} connected with reason: {reason}");
        }
    }
}
