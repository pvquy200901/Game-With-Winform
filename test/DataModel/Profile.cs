namespace test.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Profile")]
    public partial class Profile
    {
        [Key]
        public int ID_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? Score { get; set; }
    }
}
