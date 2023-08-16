using BitwiseOperations;


namespace DSAConcepts 
{
    public class Program
    {
        
        static string input = String.Empty;
        public static void Main()
        {
            Program dm = new Program();
            try
            {

                do
                {
                    
                    dm.DisplayMenu();

                    switch (input)
                    {
                        case "1":
                            {

                                Console.WriteLine("Going to perform the bitwise operations.\n");
                                Complements();
                                break;
                            }
                        case "#":
                            {
                                Console.WriteLine("Thankyou for using the application. \nExiting the application now.");
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
        }




        public void DisplayMenu()
        {

            Console.WriteLine("******** Application Menu ********\n");

            Console.WriteLine("1. Compliment Operations\n");

            Console.WriteLine("#. Exit\n");
            Console.WriteLine("Please enter your input");
            input = Console.ReadLine();

        }

        static void Complements()
        {
            Complement complement = new Complement();

            Console.WriteLine("Please Enter a Binary number: ");
            string BinaryNum = Console.ReadLine();
            string res = complement.OnesComp(BinaryNum);
            Console.WriteLine("One's complement: " + res);
        }
    }
}