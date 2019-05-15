using System;

namespace HMS.Models
{
    public class TaxBase
    {
        public Guid ID { get; set; }
        public string TaxItem { get; set; }
        public TaxType TaxType { get; set; }
        public decimal TaxAmount { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
