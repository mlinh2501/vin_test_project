using System;

namespace HMS.Models
{
    public class ReservationCancellationInfo
    {
        public Guid ID { get; set; }
        public Guid ReservationID { get; set; }
        public string CancellationPolicyRefID { get; set; }
        public string CancellationPolicyName { get; set; }
        public bool IsRefundable { get; set; }
        public decimal? CancelPenaltyAmount { get; set; }
        public decimal? CancelPenaltyPercent { get; set; }
        public int CancelPenaltyNumberNights { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
