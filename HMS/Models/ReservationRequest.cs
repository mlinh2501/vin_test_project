using System;

namespace HMS.Models
{
    public class ReservationRequest
    {
        public Guid ID { get; set; }
        public Guid ReservationID { get; set; }
        public RequestType RequestType { get; set; }
        public string RequestContent { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
