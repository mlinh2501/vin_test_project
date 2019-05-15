using System;

namespace HMS.Models
{
    public class ReservationCancellationPolicy
    {
        public Guid ID { get; set; }
        public Guid ReservationID { get; set; }
        public string CancellationPolicyRefID { get; set; }
        public string CancellationPolicyName { get; set; }
        public string CancellationDescription { get; set; }
        public string JsonValue { get; set; }
        public bool CanCancel { get; set; }
        public bool NonRefundable { get; set; }
        public int HourThresholdBeforeReservation { get; set; }
        public decimal? CancelPenaltyAmount { get; set; }
        public decimal? CancelPenaltyPercent { get; set; }
        public int CancelPenaltyNumberNights { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
