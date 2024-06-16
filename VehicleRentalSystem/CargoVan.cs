namespace VehicleRentalSystem
{
    public class CargoVan : Vehicle
    {
        public int DriversExperience { get; set; }

        public override decimal RentalCostPerDay(int rentalDays)
        {
            return rentalDays <= 7 ? 50m : 40m;
        }

        public override decimal InsurancePercentageDaily()
        {
            return 0.0003m;
        }

        public override decimal InsuranceDiscount()
        {
            return DriversExperience > 5 ? 0.15m : 0m;
        }

    }
}
