namespace AngularApiComDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comment
    {
        public int CommentID { get; set; }

        [Required]
        [StringLength(2000)]
        public string CommentBody { get; set; }

        public DateTime CommentCreateDate { get; set; }

        public bool CommentIsBlocked { get; set; }

        public bool CommentIsActive { get; set; }

        public int FKPostID { get; set; }

        public int FKUserID { get; set; }

        public virtual Post Post { get; set; }

        public virtual User User { get; set; }
    }
}
