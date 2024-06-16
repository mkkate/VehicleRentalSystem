namespace VehicleRentalSystem.Extensions
{
    public static class PrintExtension
    {
        public static string ToTwoDecimals(this decimal value)
        {
            return value.ToString("0.00");
        }
    }
}
