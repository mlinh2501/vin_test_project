using System;

namespace HMS.Models
{
    public class ReservationRatePlanInfo
    {
        public Guid ID { get; set; }
        public Guid ReservationRoomRateID { get; set; }
        public string RatePlanName { get; set; }
        public string RatePlanCode { get; set; }
        public string RatePlanDescription { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string JsonValue { get; set; }
    }
}
