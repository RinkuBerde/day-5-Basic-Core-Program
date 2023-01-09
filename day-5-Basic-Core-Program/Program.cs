namespace day_5_Basic_Core_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print message
            Console.WriteLine("Welcome to Basic Core Program!!!");

            //Flip Coin 
            FlipCoin flipcoin = new FlipCoin();
            flipcoin.PercentageFlips(10);

            //Leap Year
            CheckLeapYear.LeapYear();
        }
    }
}