namespace AngularApiComDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Blogs = new HashSet<Blog>();
            Comments = new HashSet<Comment>();
            Posts = new HashSet<Post>();
            BlogContributers = new HashSet<BlogContributer>();
        }

        public int UserID { get; set; }

        [Required]
        [StringLength(300)]
        public string UserFirstName { get; set; }

        [Required]
        [StringLength(300)]
        public string UserLastName { get; set; }

        [StringLength(300)]
        public string UserNickName { get; set; }

        [Required]
        [StringLength(300)]
        public string UserEmail { get; set; }

        [Required]
        [StringLength(50)]
        public string UserPassword { get; set; }

        public bool UserIsBlocked { get; set; }

        [StringLength(300)]
        public string UserPhoto { get; set; }

        public int FKRoleID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Blog> Blogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Posts { get; set; }

        public virtual UserRole UserRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogContributer> BlogContributers { get; set; }
    }
}
