namespace Dice;

public class RollDice
{
    private Random rnd = new Random();

    public int[] GetRollStats(int totalRolls)
    {
        int[] counts = new int[13];
        for (int i = 0; i < totalRolls; i++)
        {
            int rollSum = rnd.Next(1,7) + rnd.Next(1, 7);
            counts[rollSum]++;
        }
        return counts;
    }
}