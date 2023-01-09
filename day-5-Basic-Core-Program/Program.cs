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
         
            //Power of 2
            PowerOf2 pow = new PowerOf2();
            pow.CheckPower(5);

            //Harmonic Number
            HarmonicNum har = new HarmonicNum();
            har.HarmonicNumber(5);

            //Prime Factorization
            PrimeFactorization.PrimeFactor();

            //to Compute Quotient and Remainder
            QuotientNRemainder div = new QuotientNRemainder();
            div.Divide(315,3);

         






        }
}
}