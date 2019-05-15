using System;

namespace HMS.Models
{
    public class ReservationGuaranteeInfo
    {
        public Guid ID { get; set; }
        public Guid ReservationID { get; set; }
        public string GuaranteeRefID { get; set; }
        public string GuaranteeName { get; set; }
        public GuaranteeType GuaranteeType { get; set; }
        public GuaranteeMethod GuaranteeMethod { get; set; }
        public string GuaranteeValue { get; set; }
        public string GuaranteeDescription { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
