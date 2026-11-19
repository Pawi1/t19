namespace FiveDiceLib;
using System.Linq;

public static class FiveDiceLib
{
    public static string Roll(int[] dices)
    {
        if (dices.Length != 5 || dices.Any(d => d is < 1 or > 6))
            return "wrong set";
        var counts = dices.GroupBy(d => d)
            .Select(g => g.Count())
            .OrderByDescending(c => c)
            .ToArray();

        if (counts[0] == 5) return "five of a kind";
        if (counts[0] == 4) return "four of a kind";
        if (counts[0] == 3 && counts[1] == 2) return "full house";

        var set = new HashSet<int>(dices);

        if (set.Count == 5 && set.Max() - set.Min() == 4)
            return "large straight";

        if (Enumerable.Range(1, 3).Any(s => Enumerable.Range(s, 4).All(set.Contains)))
            return "small straight";

        if (counts[0] == 3) return "three of a kind";
        if (counts[0] == 2 && counts[1] == 2) return "two pair";
        if (counts[0] == 2) return "pair";

        return "no pair";
    }
}