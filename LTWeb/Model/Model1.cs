namespace LTWeb.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<menu> menus { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
