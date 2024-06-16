I came up with a soltion to use abstraction, since the abstract class (parent) contains fields and methods common for each vehicle type, 
and each vehicle type (child class) has it's own characteristic. So, my abstract class is **Vehicle** having common fields like 
Brand, Model, Value and abstract methods overriden by each child, since each child has different implementation of the abstract methods.

At the moment of renting a vehicle, a **Rental** is created, holding information about customer name, reservation start and end date, 
actual return date and a reference to the rented vehicle.

At the moment of returning the rented vehicle, an **Invoice** is generated, holding all the information needed for the application's output.
The Invoice class has the reference to the Rental, since all Rental's fields are needed for the invoice.

For better code readability, there are two additional folders:
- **Extensions**, holding extension methods: **InvoiceExtension** with Print method that extends the Invoice in output form, 
and **PrintExtension** with ToTwoDecimals method that extends the decimal value to the requested format with 2 decimals.
- **Helpers**: DayHelper holding methods for date and days calculations,
and InvoicePrintHelper holding methods with data and format for each part of the invoice output.

Input values are part of the Main class, with this flow for each vehicle type: 
1) The vehicle type object is created
2) The rental referencing that vehicle is created
3) Invoice referencing that rental is generated and printed.
