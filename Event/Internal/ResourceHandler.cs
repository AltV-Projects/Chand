using System;
using AltV.Net;
using Chand.Data;

namespace Chand.Event.Internal
{
    class ResourceHandler : Resource
    {
        public override void OnStart()
        {
            Alt.Log("Resource Chand starting");
            try
            {
                ChandContext dbContext = new ChandContext();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public override void OnStop()
        {
            Alt.Log("Resource Chand stopping");
        }
    }
}
