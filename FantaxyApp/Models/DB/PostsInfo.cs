using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class PostsInfo
    {
        public int IdPost { get; set; }
        public string PostText { get; set; } = null!;
        public DateTime PostDate { get; set; }

        public virtual Post IdPostNavigation { get; set; } = null!;
    }
}
