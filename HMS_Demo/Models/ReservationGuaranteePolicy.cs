using System;

namespace HMS.Models
{
    public class ReservationGuaranteePolicy
    {
        public Guid ID { get; set; }
        public Guid ReservationID { get; set; }
        public string GuaranteePolicyRefID { get; set; }
        public string GuaranteePolicyName { get; set; }
        public string GuaranteePolicyDescription { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public decimal? DepositAmount { get; set; }
        public decimal? DepositPercent { get; set; }
        public int? DepositNumberNights { get; set; }
        public int? DepositTiming { get; set; }
        public int? DepositDays { get; set; }
        public string JsonValue { get; set; }
    }
}
