using System;

namespace HMS.Models
{
    public class FeeBase
    {
        public Guid ID { get; set; }
        public string FeeItem { get; set; }
        public FeeType FeeType { get; set; }
        public decimal FeeAmount { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
