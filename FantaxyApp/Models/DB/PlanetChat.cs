using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class PlanetChat
    {
        public int IdChat { get; set; }
        public int? IdPlanet { get; set; }

        public virtual Chat IdChatNavigation { get; set; } = null!;
        public virtual Planet? IdPlanetNavigation { get; set; }
    }
}
