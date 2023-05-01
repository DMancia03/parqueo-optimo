namespace Sistema_de_parqueo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class parking_slot_reservation
    {
        [Key]
        public int id_reservation { get; set; }

        [Required]
        [StringLength(50)]
        public string customer_DUI { get; set; }

        public int id_parking_slot { get; set; }

        public DateTime hora_reserva { get; set; }

        public int duration_in_minutes { get; set; }

        public DateTime hora_finalizada { get; set; }

        public virtual parking_slot parking_slot { get; set; }
    }
}
