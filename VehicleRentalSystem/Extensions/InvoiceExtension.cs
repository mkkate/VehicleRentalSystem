using VehicleRentalSystem.Helpers;

namespace VehicleRentalSystem.Extensions
{
    public static class InvoiceExtension
    {
        public static void Print(this Invoice invoice)
        {
            string vehicleType = string.Empty;
            string printInfo = string.Empty;
            string vehicleSpecificValue = string.Empty;

            switch (invoice.Rental.RentedVehicle)
            {
                case Car car:
                    vehicleType = "car";
                    vehicleSpecificValue += $"has a security rating of {car.SafetyRating}:";
                    break;
                case Motorcycle motorcycle:
                    vehicleType = "motorcycle";
                    vehicleSpecificValue += $"the driver is {motorcycle.RidersAge} years old:";
                    break;
                case CargoVan cargoVan:
                    vehicleType += "cargo van";
                    vehicleSpecificValue += $"the driver has {cargoVan.DriversExperience} years of driving experience:";
                    break;
            }

            printInfo += InvoicePrintHelper.RentalBaseInformation(invoice, vehicleType, vehicleSpecificValue);

            printInfo += InvoicePrintHelper.ReservationPart(invoice);

            printInfo += InvoicePrintHelper.ActualPart(invoice);

            printInfo += InvoicePrintHelper.AdditionalCost(invoice);

            if (DaysHelper.CountRemainingDays(invoice.ReservedRentalDays, invoice.ActualRentalDays) != 0)
            {
                printInfo += InvoicePrintHelper.EarlyDiscount(invoice);
            }

            printInfo += InvoicePrintHelper.Total(invoice);

            Console.WriteLine(printInfo);
        }
    }
}
