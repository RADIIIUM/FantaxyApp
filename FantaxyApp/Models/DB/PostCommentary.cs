using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class PostCommentary
    {
        public int IdComment { get; set; }
        public int? IdPost { get; set; }

        public virtual Comment IdCommentNavigation { get; set; } = null!;
        public virtual Post? IdPostNavigation { get; set; }
    }
}
