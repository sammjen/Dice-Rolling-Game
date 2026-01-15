namespace Dice;
internal class Program
{
    public static void Main()
    {
        
        Console.WriteLine("How many times do you want to roll the dice?");
        
        int numberDice = int.Parse(Console.ReadLine());
        
        RollDice roller = new RollDice();
        
        int[] results = roller.GetRollStats(numberDice);
        
        Console.WriteLine("\nDice Rolling Results:");
        for (int i = 2; i <= 12; i++)
        {
            double percentage = ((double)results[i] / numberDice) * 100;
            string label = i.ToString().PadRight(2) + ": ";
            string stars = new string('*', (int)Math.Round(percentage));
            Console.WriteLine(label + stars);
        }
    }
}