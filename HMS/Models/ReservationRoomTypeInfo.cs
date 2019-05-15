using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public class ReservationRoomTypeInfo
    {
        public Guid ID { get; set; }
        public Guid ReservationRoomRateID { get; set; }
        public string RoomTypeName { get; set; }
        public string RoomTypeCode { get; set; }
        public string RoomTypeDescription { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public string JsonValue { get; set; }

        public IList<ReservationRoomTypeAmenityInfo> Amenities { get; set; }
    }
}
