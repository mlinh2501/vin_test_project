using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public class ReservationProfile
    {
        public Guid ID { get; set; }
        public Guid ReservationID { get; set; }
        public string ProfileRefID { get; set; }
        public ProfileType ProfileType { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PassportId { get; set; }
        public DateTime PassportExpiredDate { get; set; }
        public GenderType GenderType { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public virtual IList<ReservationProfileReferenceID> ProfileReferenceIDs { get; set; }
    }
}
