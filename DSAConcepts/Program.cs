
string input= String.Empty;
try
{

    do
    {
        DisplayMenu();
        switch (input)
        {
            case "1":
                {
                    Console.WriteLine("Going to perform the bitwise operations.");
                    break;
                }
            case "#":
                {
                    Console.WriteLine("Exiting the application. Thankyou for using");
                    break;
                }

            default:
                {
                    Console.WriteLine("****** Invalid Input ******\nPlease enter the valid input.");
                    break;
                }
        }
    } while (input != "#");
}
catch (Exception ex)
{
    Console.WriteLine("Exception Message: ", ex.Message);
    throw;
}


void DisplayMenu()
{

    Console.WriteLine("******** Application Menu ********\n");
    Console.WriteLine("1. Bitwise Operations\n");

    Console.WriteLine("#. Exit\n");
    Console.WriteLine("Please enter your input");
    input = Console.ReadLine();

}