namespace KudVenkat.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDepartment
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool? isSelected { get; set; }
    }
}
