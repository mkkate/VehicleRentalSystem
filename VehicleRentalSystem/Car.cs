namespace VehicleRentalSystem
{
    public class Car : Vehicle
    {
        public int SafetyRating { get; set; }

        public override decimal RentalCostPerDay(int rentalDays)
        {
            return rentalDays <= 7 ? 20m : 15m;
        }

        public override decimal InsurancePercentageDaily()
        {
            return 0.0001m;
        }

        public override decimal InsuranceDiscount()
        {
            return SafetyRating >= 4 ? 0.1m : 0m;
        }
    }
}
