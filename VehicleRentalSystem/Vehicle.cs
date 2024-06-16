namespace VehicleRentalSystem
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Value { get; set; }


        public abstract decimal RentalCostPerDay(int rentalDays);
        public abstract decimal InsurancePercentageDaily();
        public abstract decimal InsuranceDiscount();
    }
}
