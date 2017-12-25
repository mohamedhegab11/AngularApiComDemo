namespace AngularApiComDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BlogContributer
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FKBlogID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FKUserID { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsActive { get; set; }

        public virtual Blog Blog { get; set; }

        public virtual User User { get; set; }
    }
}
