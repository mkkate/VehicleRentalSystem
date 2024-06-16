using VehicleRentalSystem.Extensions;

namespace VehicleRentalSystem.Helpers
{
    public static class InvoicePrintHelper
    {
        public static string RentalBaseInformation(Invoice invoice, string vehicleType, string renterSpecification)
        {
            return $"A {vehicleType} valued at ${invoice.Rental.RentedVehicle.Value}, and {renterSpecification}\n\n" +
                $"XXXXXXXXXX\n" +
                $"Date: {invoice.Rental.ActualReturnDate}\n" +
                $"Customer Name: {invoice.Rental.CustomerName}\n" +
                $"Rented Vehicle: {invoice.Rental.RentedVehicle.Brand} {invoice.Rental.RentedVehicle.Model}\n\n";
        }

        public static string ReservationPart(Invoice invoice)
        {
            return $"Reservation start date: {invoice.Rental.ReservationStartDate}\n" +
                $"Reservation end date: {invoice.Rental.ReservationEndDate}\n" +
                $"Reserved rental days: {invoice.ReservedRentalDays} days\n\n";
        }

        public static string ActualPart(Invoice invoice)
        {
            return $"Actual return date: {invoice.Rental.ActualReturnDate}\n" +
                $"Actual rental days: {invoice.ActualRentalDays} days\n\n";
        }

        public static string AdditionalCost(Invoice invoice)
        {
            if (invoice.InitialInsurancePerDay == invoice.InsurancePerDay)
            {
                return $"Rental cost per day: ${invoice.RentalCostPerDay.ToTwoDecimals()}\n" +
               $"Insurance per day: ${invoice.InsurancePerDay.ToTwoDecimals()}\n\n";
            }
            else
            {
                return $"Rental cost per day: ${invoice.RentalCostPerDay.ToTwoDecimals()}\n" +
                    $"Initial insurance per day: ${invoice.InitialInsurancePerDay.ToTwoDecimals()}\n" +
                    $"Insurance addition per day: ${Math.Abs(invoice.InsuranceDiscountPerDay).ToTwoDecimals()}\n" +
                    $"Insurance per day: ${invoice.InsurancePerDay.ToTwoDecimals()}\n\n";
            }
        }

        public static string EarlyDiscount(Invoice invoice)
        {
            return $"Early return discount for rent: ${invoice.EarlyReturnDiscountForRent.ToTwoDecimals()}\n" +
                $"Early return discount for insurance: ${invoice.EarlyReturnDiscountForInsurance.ToTwoDecimals()}\n\n";
        }

        public static string Total(Invoice invoice)
        {
            return $"Total rent: ${invoice.TotalRent.ToTwoDecimals()}\n" +
                $"Total insurance: ${invoice.TotalInsurance.ToTwoDecimals()}\n" +
                $"Total: ${invoice.TotalCost.ToTwoDecimals()}\n" +
                $"XXXXXXXXXX";
        }
    }
}
