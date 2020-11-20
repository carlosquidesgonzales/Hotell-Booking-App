using System;

namespace HotellbookingEF.Model
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int BookingId { get; set; }
        public string InvoiceStatus { get; set; }
        public decimal Total { get; set; }
        public DateTime? DatePaid { get; set; }
        public virtual Booking Booking { get; set; }

    }
}
