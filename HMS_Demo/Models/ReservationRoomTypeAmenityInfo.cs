using System;

namespace HMS.Models
{
    public class ReservationRoomTypeAmenityInfo
    {
        public Guid ID { get; set; }
        public Guid ReservationRoomTypeInfoID { get; set; }
        public Guid RefID { get; set; }
        public AmenityType Type { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
