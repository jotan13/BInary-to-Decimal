using System;

namespace Projects
{
    class Project1
    {
        public static void MainP1(string[] args)
        {
            //Part 1: User can enter up to 8 binary digits in one input field

            int Decimal = 0;
            string binary;

            Console.Write("Welcome to the binary to decimal calculator! \nPlease enter some binary you wish to convert to decimal, make sure it does not exceed 8 digits.\n\nBinary: ");

            binary = Console.ReadLine();

            try
            {
                if (binary.Length > 8)
                {
                    Console.WriteLine("Your number has exceeded 8 digits.");
                    return;
                }
                else
                {
                    foreach (char digit in binary)
                    {
                        if (digit != '0' && digit != '1')
                        {
                            //Part 2: User must be notified if anything other than a 0 or 1 was entered   

                            Console.WriteLine("Only 0s and 1s.");
                            return;

                        } 
                    }
                }
                foreach (char digit in binary)
                {
                    Decimal = (Decimal << 1) + (digit - '0');
                }
                //Part 3: User views the results in a single output field containing the decimal (base 10) equivalent of the binary number that was entered
                Console.WriteLine("Decimal: " + Decimal);

            } catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return;
            }
     
        }
    }
}