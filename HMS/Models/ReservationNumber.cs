using System;

namespace HMS.Models
{
    public class ReservationNumber
    {
        public Guid ReservationID { get; set; }
        public string ItineraryNumber { get; set; }
        public string RoomConfirmationNumber { get; set; }
        public string RoomCancellationNumber { get; set; }
    }
}
