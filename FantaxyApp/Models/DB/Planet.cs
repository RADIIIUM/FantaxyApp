using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class Planet
    {
        public Planet()
        {
            PlanetChats = new HashSet<PlanetChat>();
            PlanetProfileRoles = new HashSet<PlanetProfileRole>();
            PlanetProfiles = new HashSet<PlanetProfile>();
            PlanetReports = new HashSet<PlanetReport>();
            PlanetStatuses = new HashSet<PlanetStatus>();
        }

        public int IdPlanet { get; set; }
        public string? LoginOwner { get; set; }
        public string? Curator { get; set; }

        public virtual User? CuratorNavigation { get; set; }
        public virtual User? LoginOwnerNavigation { get; set; }
        public virtual MainPageInfo? MainPageInfo { get; set; }
        public virtual PlanetInfo? PlanetInfo { get; set; }
        public virtual ICollection<PlanetChat> PlanetChats { get; set; }
        public virtual ICollection<PlanetProfileRole> PlanetProfileRoles { get; set; }
        public virtual ICollection<PlanetProfile> PlanetProfiles { get; set; }
        public virtual ICollection<PlanetReport> PlanetReports { get; set; }
        public virtual ICollection<PlanetStatus> PlanetStatuses { get; set; }
    }
}
