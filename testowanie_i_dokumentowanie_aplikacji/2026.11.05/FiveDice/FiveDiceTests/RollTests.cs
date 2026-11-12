namespace FiveDiceTests;
using FiveDiceLib;

public class Tests
{
    [TestCase(new[] { 1, 1, 1, 1, 1 }, "five of a kind")]
    [TestCase(new[] { 5, 5, 5, 6, 5 }, "four of a kind")]
    [TestCase(new[] { 2, 5, 6, 4, 3 }, "large straight")]
    [TestCase(new[] { 4, 3, 3, 3, 1 }, "three of a kind")]
    [TestCase(new[] { 4, 6, 2, 6, 5 }, "pair")]
    [TestCase(new[] { 1, 4, 5, 6, 2 }, "no pair")]
    [TestCase(new[] { 1, 3, 4, 6, 2 }, "small straight")]
    [TestCase(new[] { 2, 2, 5, 2, 5 }, "full house")]
    [TestCase(new[] { 6, 4, 5, 6, 4 }, "two pair")]
    public void Roll_ReturnsExpectedCombination(int[] dice, string expected)
    {
        Assert.That(FiveDiceLib.Roll(dice), Is.EqualTo(expected));
    }
}