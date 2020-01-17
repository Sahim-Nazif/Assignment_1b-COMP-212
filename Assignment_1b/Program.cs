using System;

namespace Assignment_1b
{
    //declaring delegate
    public delegate void CarInventory();
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\nWelcome To COMP 212 INVENTORY EVENT PROGRAM OF NAZIF SAHIM");


        }

        public static void CarSold()
        {
            Console.WriteLine("\nHow many cars are in Stock currently  ? " + " ");
            int car = int.Parse(Console.ReadLine());
            for (int i=0; i<car; i++)
            {
                Console.WriteLine("\nHow many cars did you sell ? " + " ");
                int sold = int.Parse(Console.ReadLine());

                if (sold>car)
                {
                    Console.WriteLine("Error.. Please check ! You sold more than inventory ?");
                }
                else
                {
                    car = car - sold;
                }
            }
        }
    }
}
