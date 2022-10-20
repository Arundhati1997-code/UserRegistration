// See https://aka.ms/new-console-template for more information
using UserRegistration;

Console.WriteLine("Welcome to User Registration Problem");
Console.WriteLine("Enter 1 for First Name");
Console.WriteLine("Enter 2 for Last Name");

int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
        RegexFirstName firstName = new RegexFirstName();
        bool ValidName = firstName.validateString("Arundhati");
        Console.WriteLine("{0}", (ValidName) ? "Valid" : "Invalid");
        break;

    case 2:
        RegexLastName lastName = new RegexLastName();
        bool ValidName2 = lastName.validateString("Raina");
        Console.WriteLine("{0}", (ValidName2) ? "Valid" : "Invalid");
        break;
}
