using System;

namespace HMS.Models
{
    public class ReservationPropertyInfo
    {
        public Guid ID { get; set; }
        public Guid ReservationID { get; set; }
        public string JsonValue { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
