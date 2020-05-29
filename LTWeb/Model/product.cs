namespace LTWeb.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public double? price { get; set; }

        [StringLength(50)]
        public string img { get; set; }

        [Column(TypeName = "ntext")]
        public string description { get; set; }

        public string meta { get; set; }

        [StringLength(10)]
        public string size { get; set; }

        [StringLength(30)]
        public string color { get; set; }

        public bool? hide { get; set; }

        public int? order { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? datebegin { get; set; }

        public int? category { get; set; }
    }
}
