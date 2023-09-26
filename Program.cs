namespace Labb4___Felsökning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //case 1
            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre"); // detta ";" tecken saknades.
            }

            else if(number < 3) //la till mellanslag mellan else och if.
{
                Console.WriteLine("Talet är mindre än tre");
            }
        }
    }
}