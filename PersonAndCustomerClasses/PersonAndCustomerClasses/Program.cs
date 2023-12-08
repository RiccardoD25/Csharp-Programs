using System;

//Defining the Person class
class Person
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
}
//Defining the Customer class derived from Person
class Customer : Person
{
    public int CustomerNumber { get; set; }
    public bool IsOnMailingList { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        //Created a Customer object
        Customer customer = new Customer
        {
            Name = "Riccardo De Simini",
            Address = "123 Florida Avenue",
            PhoneNumber = "954-123-4567",
            CustomerNumber = 1200,
            IsOnMailingList = true
        };
        //Displays customer information 
        Console.WriteLine("Customer Information:");
        Console.WriteLine("Name: " + customer.Name);
        Console.WriteLine("Address: " + customer.Address);
        Console.WriteLine("Phone Number: " + customer.PhoneNumber);
        Console.WriteLine("Customer Number: " + customer.CustomerNumber);
        Console.WriteLine("On Mailing List: " + (customer.IsOnMailingList ? "Yes" : "No"));
    }
}