namespace Sistema_de_parqueo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer
    {
        [Key]
        public int id_customer { get; set; }

        [StringLength(50)]
        public string customer_name { get; set; }

        [StringLength(50)]
        public string customer_lastname { get; set; }

        [StringLength(50)]
        public string customer_DUI { get; set; }

        [StringLength(100)]
        public string customer_password { get; set; }
    }
}
