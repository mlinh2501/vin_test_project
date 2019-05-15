using System;

namespace HMS.Models
{
    public class ReservationLog
    {
        public Guid ID { get; set; }
        public Guid ReservationID { get; set; }
        public ReservationAction Action { get; set; }
        public string Notes { get; set; }
        public string UserRefID { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
