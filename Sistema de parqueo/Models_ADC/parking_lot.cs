namespace Sistema_de_parqueo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class parking_lot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public parking_lot()
        {
            parking_slot = new HashSet<parking_slot>();
        }

        [Key]
        public int id_parking_lot { get; set; }

        [Required]
        [StringLength(50)]
        public string is_parking_lot_full { get; set; }

        public int numbers_of_slots { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<parking_slot> parking_slot { get; set; }
    }
}
