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
                Console.WriteLine("Talet är större än tre"); // ett semilkolon saknades.
            }

            else if(number < 3) //la till mellanslag mellan else och if.
{
                Console.WriteLine("Talet är mindre än tre");
            }

            //case 2

            for (int i = 1; i <= 100; i++) // la till "=" efter "<", då skrivs 1 till 100 ut.
            {
                Console.WriteLine(i);
            }

            //case 3
            for (int i = 1; i <= 5; i++) // la til ++ på i
            {
                for (int j = 1; j <= i; j++) // la till ++ på j
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            //case 4
            int p = 1;
            while (p <= 5)
            {
                for (int j = 1; j <= p; j++)
                {
                    Console.Write(j); //Skriver ut värdet "j".
                }

                Console.WriteLine(p); //Skriver ut värdet "p".
                p++;
            }

            //case 5
            int o = 1;

            switch (o)
            {
                case 1:
                    break; //la till break;
                
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }

            //case 6
            int h = 10;

            if (h == 5) //la till det andra "=" tecknet.
            {
                Console.WriteLine("h är 5");
            }



        }
    }
}