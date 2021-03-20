using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    

    public class NavRouteEvent : JournalEvent<NavRouteEvent.NavRouteEventArgs>
    {
        public NavRouteEvent() : base("_NavRoute") { }

        public class NavRouteEventArgs :JournalEventArgs
        {
            public NavRouteItem[] Route { get; set; }
        }

        public class NavRouteItem 
        {
            public string StarSystem { get; set; }
            public string SystemAddress { get; set; }

            [JsonConverter(typeof(SystemPositionConverter))]
            public SystemPosition StarPos { get; set; }

            public string StarClass { get; set; }
        }
    }

    internal class InternalNavRouteEvent : JournalEvent<NavRouteEvent.NavRouteEventArgs>
    {
        public InternalNavRouteEvent() : base("NavRoute") { }

    }

}
