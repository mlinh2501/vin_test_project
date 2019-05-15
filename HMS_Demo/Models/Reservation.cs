using System;
using System.Collections.Generic;

namespace HMS.Models
{
    public class Reservation
    {
        public Guid ID { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public ReservationStatus Status { get; set; }
        public string PropertyID { get; set; }
        public string PropertyCode { get; set; }
        public string PropertyName { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfRooms { get; set; }
        public DateTime? CancellationDate { get; set; }
        public int NumberOfAdults { get; set; }
        public string RoomConfirmationNumber { get; set; }
        public string ItineraryNumber { get; set; }
        public decimal Total { get; set; }
        public string CurrencyCode { get; set; }
        public string PromotionCode { get; set; }
        public string DistributionChannel { get; set; }
        public TravelType TravelType { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public ReservationPropertyInfo PropertyInfo { get; set; }

        //Support search fields
        public string ProfileNames { get; set; }
        public string ProfileEmails { get; set; }
        public string ProfilePhones { get; set; }
        public string ProfileReferenceIDs { get; set; }
        public string RoomTypeCodes { get; set; }
        public string RoomTypeNames { get; set; }
        public string RatePlanCodes { get; set; }
        public string RatePlanNames { get; set; }
        public string ReservationReferenceIDs { get; set; }
        public int NumberOfOtherOccupancies { get; set; }

        public IList<ReservationTax> Taxes { get; set; }
        public IList<ReservationFee> Fees { get; set; }
        public IList<ReservationCancellationInfo> CancellationInfos { get; set; }
        public IList<ReservationCancellationPolicy> CancellationPolicies { get; set; }
        public IList<ReservationGuaranteeInfo> GuaranteeInfos { get; set; }
        public IList<ReservationGuaranteePolicy> GuaranteePolicies { get; set; }
        public IList<ReservationOtherOccupancy> OtherOccupancies { get; set; }
        public IList<ReservationReferenceID> ReferenceIds { get; set; }
        public IList<ReservationRequest> Requests { get; set; }
        public IList<ReservationLog> Logs { get; set; }
        public IList<ReservationExtra> Extras { get; set; }
        public IList<ReservationProfile> Profiles { get; set; }
        public IList<ReservationRoomRate> RoomRates { get; set; }
    }
}
