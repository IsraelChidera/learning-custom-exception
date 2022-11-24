namespace CustomsException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //CustomException.Radio custom = new CustomException.Radio();
            CustomException.Radio custom = new CustomException.Radio();
            custom.onSwitch(false);

            CustomException.Car car = new(10,"Lexus");
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    car.Accelerate(10);
                }
            }
            catch(Exception e)
            {
                // Handle the thrown exception.
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Method: {0}", e.TargetSite);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
            }
            
        }
    }
}