using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public class ReservationRoomRate
    {
        public Guid ID { get; set; }
        public Guid ReservationID { get; set; }
        public DateTime StayDate { get; set; }
        public string RoomTypeCode { get; set; }
        public string RoomTypeName { get; set; }
        public string RoomTypeRefID { get; set; }
        public string RatePlanCode { get; set; }
        public string RatePlanName { get; set; }
        public string RatePlanRefID { get; set; }
        public decimal RateAmount { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public virtual ReservationRatePlanInfo RatePlanInfo { get; set; }
        public virtual IList<ReservationRoomRateFee> Fees { get; set; }
        public virtual IList<ReservationRoomRateTax> Taxes { get; set; }
        public virtual ReservationRoomTypeInfo RoomTypeInfo { get; set; }
    }
}
