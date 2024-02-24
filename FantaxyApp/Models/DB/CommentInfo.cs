using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class CommentInfo
    {
        public int IdComment { get; set; }
        public string CommentText { get; set; } = null!;

        public virtual Comment IdCommentNavigation { get; set; } = null!;
    }
}
