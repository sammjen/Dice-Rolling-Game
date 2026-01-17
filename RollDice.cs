namespace Dice;
//using the number of rolls from the first class
public class RollDice
{
    //using random in order to get random dice rolling
    private Random rnd = new Random();

    public int[] GetRollStats(int totalRolls)
    {
        //setting up our array using 13 (all the possible numbers 1-12)
        int[] counts = new int[13];
        //iterating through the number of times we want to roll
        for (int i = 0; i < totalRolls; i++)
        {
            int rollSum = rnd.Next(1,7) + rnd.Next(1, 7);
            counts[rollSum]++;
            //adding a 1 to the array for that roll number
        }
        //our array gets returned back to the original class
        return counts;
    }
}