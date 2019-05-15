using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public class ReservationExtra
    {
        public Guid ID { get; set; }
        public Guid ReservationID { get; set; }
        public DateTime StayDate { get; set; }
        public string ExtraCode { get; set; }
        public string ExtraName { get; set; }
        public ExtraType Type { get; set; }
        public decimal RateAmount { get; set; }
        public int Quantity { get; set; }
        public string JsonValue { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public virtual IList<ReservationExtraFee> Fees { get; set; }
        public virtual IList<ReservationExtraTax> Taxes { get; set; }
    }
}
