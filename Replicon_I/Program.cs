//Replicon test 1 to dispense amount entered by a user 
//Author :R Prasad
//Only needed namespace alone used
using System;


namespace Replicon_I
{
    class Program
    {
       

        public  static void Main(string[] args)
        {
            try
            {
               
               Dispenser();

            }
            catch(Exception ex)
            {

            }
         }
        
        // Action to disperse the amount entered by user
        public static void Dispenser()
        {
            try
            {
                int amount;
                Console.WriteLine("Please Enter The Amount(enter Multiples of 5 only)");
                amount = Convert.ToInt32(Console.ReadLine());
                //Check whether the input was genuine and dispersible amount and showing error amount.
                if (amount % 5 != 0)
                          {
                           Console.WriteLine("INVALID AMOUNT");
                           amount = Convert.ToInt32(Console.ReadLine());
                         }
                //Checking how many 500 currency notes need to disburse
                if (amount >= 500)
                         {
                         Console.WriteLine(" 500 * " + Convert.ToInt32(amount / 500));
                         amount = amount % 500;
                         }
                //Checking how many 100 currency notes need to disburse
                if (amount >= 100)
                         {
                          Console.WriteLine(" 100 * " + Convert.ToInt32(amount / 100));
                          amount = amount % 100;
                        
                         }
                //Checking how many 50 currency notes need to disburse
                if (amount >= 50)
                           {
                            Console.WriteLine("  50 * " + Convert.ToInt32(amount / 50));
                            amount = amount % 50;
        
                           }
                //Checking how many 10 currency notes need to disburse
                if (amount >= 10)
                         {
                          Console.WriteLine("  10 * " + Convert.ToInt32(amount / 10));
                          amount = amount % 10;

                          }
                //Checking how many 5 currency notes need to disburse
                if (amount >= 5)
                        {
                          Console.WriteLine("   5 * " + Convert.ToInt32(amount / 5));
                          amount = amount % 5;

                        }
                Console.ReadLine();
            }
            // Catching exception
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
