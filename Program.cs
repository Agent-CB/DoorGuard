namespace DoorGuard
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine(i + " plus " + j + "=" + (i + j));
            //    }
            //}

            // Om man inte innehar rätt ålder så får man inte ställa sig i kön
            // Om man har rätt ålder så får man ställa sig i kön --> blir tyvärr fullt.
            // Om man dricksar och är välklädd får man komma in direkt

            int age;
            int tip;
            int clothing;

            bool insideBar = false;

            int steps = 100;
            Console.WriteLine("promenera till krogen:");
            while(steps > 0)
            {
                Console.Write(steps + "...");
                steps = steps -1;
            }
            Console.WriteLine("framme");

            while (insideBar == false) 
            {
                Console.Write("Ange din ålder: ");
                age = int.Parse(Console.ReadLine());

                Console.WriteLine("hur mycket dricks: ");
                tip = int.Parse(Console.ReadLine());

                Console.Write("klädbetyg (1-5): ");
                clothing = int.Parse(Console.ReadLine());

                if (age < 18)
                {
                    Console.WriteLine("Du är för ung för att komma in.");
                }
                else
                    {
                    if (tip >= 20 && clothing >= 3)
                    {
                        Console.WriteLine("Välkommen in!");
                        insideBar = true;
                    }
                    else
                    {
                        Console.WriteLine("ställ dig i kön!");
                        Console.WriteLine("väntar...");
                        for(int i = 0; i <= 10; i++)
                        {
                            Console.WriteLine("väntar i kö " + i + " minuter");
                            Thread.Sleep(600);
                        }


                        Console.WriteLine("Tyvärr, kön är full. Du får vänta.");
                    }
                }

               
                Console.ReadLine();
                Console.Clear();
        }
    }
}

}
