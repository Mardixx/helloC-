// See https://aka.ms/new-console-template for more information
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


DateTime today = DateTime.Now;
DateTime dateGiven = new DateTime(2000, 07, 07);

TimeSpan difference = today - dateGiven;
/* DateTime answer = today.AddDays(2); */

Console.WriteLine("Today: {0:d.M.yyyy}", today); //{0:dddd} let's you use the variable today with a , and not a + to only display the day and not the date and time
//Console.WriteLine("Two days from now: {0:dddd}", answer); //same as the top one but 2 days in the future
Console.WriteLine(difference.Days / 365); //Gives age in years

