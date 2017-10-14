namespace KudVenkat.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KudVenkatMVCDataModel : DbContext
    {
        public KudVenkatMVCDataModel()
            : base("name=KudVenkatMVCDBContext")
        {
        }

        public virtual DbSet<tblDepartment> tblDepartments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
