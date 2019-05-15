using System;

namespace HMS.Models
{
    public class ReservationOtherOccupancy
    {
        public Guid ID { get; set; }
        public Guid ReservationID { get; set; }
        public string OccupancyRefID { get; set; }
        public string OccupancyRefCode { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
