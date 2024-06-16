using VehicleRentalSystem.Helpers;

namespace VehicleRentalSystem
{
    public class Invoice
    {
        public Rental Rental { get; set; }

        public int ReservedRentalDays { get; set; }
        public int ActualRentalDays { get; set; }

        public decimal RentalCostPerDay { get; set; }
        public decimal InitialInsurancePerDay { get; set; }
        public decimal InsurancePerDay { get; set; }
        public decimal InsuranceDiscountPerDay { get; set; }

        public decimal EarlyReturnDiscountForRent { get; set; }
        public decimal EarlyReturnDiscountForInsurance { get; set; }

        public decimal TotalRent { get; set; }
        public decimal TotalInsurance { get; set; }
        public decimal TotalCost { get; set; }


        public static Invoice Generate(Rental rental)
        {
            Invoice invoice = new Invoice();

            invoice.Rental = rental;

            invoice.ReservedRentalDays = DaysHelper.CountReservedRentalDays(rental.ReservationStartDate, rental.ReservationEndDate);
            invoice.ActualRentalDays = DaysHelper.CountActualRentalDays(rental.ReservationStartDate, rental.ActualReturnDate);

            invoice.RentalCostPerDay = rental.RentedVehicle.RentalCostPerDay(invoice.ReservedRentalDays);
            invoice.InitialInsurancePerDay = rental.RentedVehicle.Value * rental.RentedVehicle.InsurancePercentageDaily();
            invoice.InsuranceDiscountPerDay = invoice.InitialInsurancePerDay * rental.RentedVehicle.InsuranceDiscount();
            invoice.InsurancePerDay = invoice.InitialInsurancePerDay - invoice.InsuranceDiscountPerDay;

            int remainingDays = invoice.ReservedRentalDays - invoice.ActualRentalDays;
            invoice.EarlyReturnDiscountForRent = invoice.RentalCostPerDay / 2 * remainingDays;
            invoice.EarlyReturnDiscountForInsurance = invoice.InsurancePerDay * invoice.ReservedRentalDays - invoice.ActualRentalDays * invoice.InsurancePerDay;

            invoice.TotalRent = invoice.RentalCostPerDay * invoice.ReservedRentalDays - invoice.EarlyReturnDiscountForRent;
            invoice.TotalInsurance = invoice.InsurancePerDay * invoice.ReservedRentalDays - invoice.EarlyReturnDiscountForInsurance;
            invoice.TotalCost = invoice.TotalRent + invoice.TotalInsurance;

            return invoice;
        }
    }
}
