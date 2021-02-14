using AltV.Net;
using AltV.Net.Elements.Entities;

namespace Chand.Event.Internal
{
    public class NetOwnerChange : IScript
    {
        [ScriptEvent(ScriptEventType.NetOwnerChange)]
        public void OnNetOwnerChange(Entity entity, Player newOwner, Player okdOwner)
        {

        }
    }
}
