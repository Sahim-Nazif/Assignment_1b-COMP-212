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
            Console.WriteLine("**********************************************************");

            CarInventory carInventory = CarSold;
            carInventory.Invoke();
            LowStock obj = new LowStock();
            obj.carEvent += SendAlert.DisplayAlert;
            obj.Notify();

        }

        public static void CarSold()
        {
            try
            {
                Console.Write("\nHow many cars are in Stock currently  ? " + " ");
                int car = int.Parse(Console.ReadLine());
                for (int i = 0; i <= car; i++)
                {
                    Console.Write("\nHow many cars did you sell ? " + " ");
                    int sold = int.Parse(Console.ReadLine());

                    if (sold > car)
                    {
                        Console.WriteLine("Error.. Please check ! You sold more than inventory ?");
                    }
                    else
                    {
                        car -= sold;
                    }
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Please check your input ! Can only accept integer value");
            }
            
        }
    }
}
