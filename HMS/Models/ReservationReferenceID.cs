using System;

namespace HMS.Models
{
    public class ReservationReferenceID
    {
        public Guid ID { get; set; }
        public Guid ReservationID { get; set; }
        public ReferenceType Type { get; set; }
        public string Value { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
