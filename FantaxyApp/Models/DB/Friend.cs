using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class Friend
    {
        public int IdFriendship { get; set; }
        public int IdProfile1 { get; set; }
        public int IdProfile2 { get; set; }

        public virtual Profile IdProfile1Navigation { get; set; } = null!;
        public virtual Profile IdProfile2Navigation { get; set; } = null!;
    }
}
