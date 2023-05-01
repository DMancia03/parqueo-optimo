namespace Sistema_de_parqueo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class parking_slot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public parking_slot()
        {
            parking_slot_reservation = new HashSet<parking_slot_reservation>();
        }

        [Key]
        public int id_parking_slot { get; set; }

        public int id_parking_lot { get; set; }

        public int slot_number { get; set; }

        [Required]
        [StringLength(50)]
        public string is_parking_slot_free { get; set; }

        public virtual parking_lot parking_lot { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<parking_slot_reservation> parking_slot_reservation { get; set; }
    }
}
