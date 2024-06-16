namespace VehicleRentalSystem
{
    public class Motorcycle : Vehicle
    {
        public int RidersAge { get; set; }

        public override decimal RentalCostPerDay(int rentalDays)
        {
            return rentalDays <= 7 ? 15m : 10m;
        }

        public override decimal InsurancePercentageDaily()
        {
            return 0.0002m;
        }

        public override decimal InsuranceDiscount()
        {
            return RidersAge < 25 ? -0.20m : 0m;
        }
    }
}
