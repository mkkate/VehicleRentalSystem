using VehicleRentalSystem.Extensions;

namespace VehicleRentalSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Vehicle car = new Car()
        {
            Brand = "Mitsubishi",
            Model = "Mirage",
            Value = 15000.00m,
            SafetyRating = 3
        };

        Rental rentalCar = new()
        {
            CustomerName = "John Doe",
            ReservationStartDate = new DateOnly(2024, 6, 3),
            ReservationEndDate = new DateOnly(2024, 6, 13),
            ActualReturnDate = new DateOnly(2024, 6, 13),
            RentedVehicle = car
        };

        Invoice generatedCarInvoice = Invoice.Generate(rentalCar);
        generatedCarInvoice.Print();

        Console.WriteLine("-----------------------------------------------");

        Vehicle motorcycle = new Motorcycle()
        {
            Brand = "Triumph",
            Model = "Tiger Sport 660",
            Value = 10000.00m,
            RidersAge = 20
        };

        Rental rentalMotorcycle = new()
        {
            CustomerName = "Mary Johnson",
            ReservationStartDate = new DateOnly(2024, 6, 3),
            ReservationEndDate = new DateOnly(2024, 6, 13),
            ActualReturnDate = new DateOnly(2024, 6, 13),
            RentedVehicle = motorcycle
        };

        Invoice generatedMotorcycleInvoice = Invoice.Generate(rentalMotorcycle);
        generatedMotorcycleInvoice.Print();

        Console.WriteLine("-----------------------------------------------");


        CargoVan cargoVan = new CargoVan()
        {
            Brand = "Citroen",
            Model = "Jumper",
            Value = 20000.00m,
            DriversExperience = 8
        };

        Rental rentalCargoVan = new()
        {
            CustomerName = "John Markson",
            ReservationStartDate = new DateOnly(2024, 6, 3),
            ReservationEndDate = new DateOnly(2024, 6, 18),
            ActualReturnDate = new DateOnly(2024, 6, 13),
            RentedVehicle = cargoVan
        };

        Invoice generatedCargoVanInvoice = Invoice.Generate(rentalCargoVan);
        generatedCargoVanInvoice.Print();

        Console.WriteLine("-----------------------------------------------");
    }
}