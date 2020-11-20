using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotellbookingEF.Model
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int CustomerId { get; set; }
        public DateTime BookingDate { get; set; }
        [Required]
        public DateTime BookingDateStart { get; set; }
        [Required]
        public DateTime BookingDateEnd { get; set; }
        [Required]
        public int NumberOfPerson { get; set; }
        [Column(TypeName = "money")]
        public decimal Cost { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
    }
}
