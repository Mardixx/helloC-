using System;

namespace Tutorial
{
    class Program
    {
        static void Main(String[] args)
        {
            //Greeting Myself exo

            /* string pickName = "Kimi";
            Console.WriteLine(pickName + ", what is your surname?");
            if(Console.ReadLine() == "Lefort") {
                Console.WriteLine("How old are you?");
                var num = int.Parse(Console.ReadLine());
                if (num <= 18) {
                    Console.WriteLine("You're not the Kimi I know");
                } else if (num == 19) {
                    Console.WriteLine("That's my boy!");
                } else if (num >= 19) {
                    Console.WriteLine("Liar");
                }
            } else {
                Console.WriteLine("Wait, you're not me :/");
            } */


            //Gives Date, Future Date and age

            /* DateTime today = DateTime.Now;

            Console.WriteLine("Give me your birth day: ");
            Console.WriteLine("Give me your birth month: ");
            Console.WriteLine("Give me your birth year: ");

            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());

            DateTime dateGiven = new DateTime(year, month, day);

            TimeSpan difference = today - dateGiven;
            /* DateTime answer = today.AddDays(2); */

            //Console.WriteLine("Today: {0:d.M.yyyy}", today); //{0:dddd} let's you use the variable today with a , and not a + to only display the day and not the date and time
            //Console.WriteLine("Two days from now: {0:dddd}", answer); //same as the top one but 2 days in the future
            //Console.WriteLine(difference.Days / 365); //Gives age in years 

            //Math game

            /* Random rnd = new Random();
            int number = rnd.Next(0, 50);
            int number2 = rnd.Next(0, 50);

            Console.WriteLine("What is " + number + " + " + number2);
            if((int.Parse(Console.ReadLine())) == (number + number2)) {
                Console.WriteLine("Well done!");
            } else {
                Console.WriteLine("Wrong, it was " + (number + number2));
            } */

            //

        }
    }
}




