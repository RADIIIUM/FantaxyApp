using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class Status
    {
        public Status()
        {
            ChatStatuses = new HashSet<ChatStatus>();
            NewsStatuses = new HashSet<NewsStatus>();
            PlanetStatuses = new HashSet<PlanetStatus>();
        }

        public int IdStatus { get; set; }
        public string StatusName { get; set; } = null!;

        public virtual ICollection<ChatStatus> ChatStatuses { get; set; }
        public virtual ICollection<NewsStatus> NewsStatuses { get; set; }
        public virtual ICollection<PlanetStatus> PlanetStatuses { get; set; }
    }
}
