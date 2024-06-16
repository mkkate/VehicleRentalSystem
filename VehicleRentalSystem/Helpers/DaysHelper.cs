namespace VehicleRentalSystem.Helpers
{
    public static class DaysHelper
    {
        public static int CountReservedRentalDays(DateOnly reservationStartDate, DateOnly reservationEndDate)
        {
            return reservationEndDate.DayNumber - reservationStartDate.DayNumber;
        }

        public static int CountActualRentalDays(DateOnly reservationStartDate, DateOnly actualReturnDate)
        {
            return actualReturnDate.DayNumber - reservationStartDate.DayNumber;
        }

        public static int CountRemainingDays(int reservedRentalDays, int actualRentalDays)
        {
            return reservedRentalDays - actualRentalDays;
        }
    }
}
