//sam jenson, section 2, professor hilton

//creating a program that will allow us to simulate rolling dice

namespace Dice;
//setting up our Program class where we input the number of times we want to roll the 2 dice
internal class Program
{
    public static void Main()
    {
        //asking how many times we want to roll the dice
        Console.WriteLine("How many times do you want to roll the dice?");
        //passing this to a new variable
        int numberDice = int.Parse(Console.ReadLine());
        
        RollDice roller = new RollDice();
        
        int[] results = roller.GetRollStats(numberDice);
        //we then use the data from the other class to begin printing
        Console.WriteLine("\nDice Rolling Results:");
        //setting up our loop
        for (int i = 2; i <= 12; i++)
        {
            //creating the percentage per roll
            double percentage = ((double)results[i] / numberDice) * 100;
            //setting up how we print
            string label = i.ToString().PadRight(2) + ": ";
            //using the *'s to print and show the percentage of times that roll combination occured
            string stars = new string('*', (int)Math.Round(percentage));
            //printing out the final output
            Console.WriteLine(label + stars);
        }
    }
}