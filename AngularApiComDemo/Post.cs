namespace AngularApiComDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int PostID { get; set; }

        [Required]
        [StringLength(300)]
        public string PostTitle { get; set; }

        [Required]
        public string PostBody { get; set; }

        public DateTime PostCreateDate { get; set; }

        public bool PostIsBlocked { get; set; }

        public bool PostIsActive { get; set; }

        [StringLength(2000)]
        public string PostKeyWords { get; set; }

        public bool PostIsPublished { get; set; }

        public int FKBlogID { get; set; }

        public int FKUserID { get; set; }

        public bool? IsCommentable { get; set; }

        public virtual Blog Blog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual User User { get; set; }
    }
}
