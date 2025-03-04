try
{
    Console.WriteLine("Enter a number: ");
    var number = Console.ReadLine();
    Console.WriteLine($"You entered {number}");
    if (int.TryParse(number, out int parsedNumber))
    {
        if (parsedNumber == 2)
        {
            throw new Exception("Number 2 is not allowed");
        }
        else if (parsedNumber == 3)
        {
            throw new Exception("Number 3 is not allowed");
        }
        else
        {
            Console.WriteLine("Thank you for entering a valid number");
        }
    
    
    }
}
catch (Exception ex)
{   
    Console.WriteLine($"An error occured : {ex.Message}. Please try again.");
}