namespace VehicleRentalSystem
{
    public class Rental
    {
        public string CustomerName { get; set; }
        public DateOnly ReservationStartDate { get; set; }
        public DateOnly ReservationEndDate { get; set; }
        public DateOnly ActualReturnDate { get; set; }

        public Vehicle RentedVehicle { get; set; }
    }
}
