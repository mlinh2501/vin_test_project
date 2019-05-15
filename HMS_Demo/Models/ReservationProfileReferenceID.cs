using System;

namespace HMS.Models
{
    public class ReservationProfileReferenceID
    {
        public Guid ID { get; set; }
        public Guid ReservationProfileID { get; set; }
        public string ReferenceName { get; set; }
        public string ReferenceValue { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
