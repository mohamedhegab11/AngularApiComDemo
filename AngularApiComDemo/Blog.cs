namespace AngularApiComDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Blog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Blog()
        {
            BlogContributers = new HashSet<BlogContributer>();
            Posts = new HashSet<Post>();
        }

        public int BlogID { get; set; }

        [Required]
        [StringLength(300)]
        public string BlogTitle { get; set; }

        [StringLength(2000)]
        public string BlogDescription { get; set; }

        public DateTime BlogCreateDate { get; set; }

        public bool BlogIsBlocked { get; set; }

        public bool BlogIsActive { get; set; }

        [StringLength(300)]
        public string BlogHeaderPhoto { get; set; }

        public int FKUserID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogContributer> BlogContributers { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Posts { get; set; }
    }
}
