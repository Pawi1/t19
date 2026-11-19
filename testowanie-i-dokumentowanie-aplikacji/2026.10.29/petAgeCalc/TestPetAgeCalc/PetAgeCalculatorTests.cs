namespace TestPetAgeCalc;
using PetAgeCalc;
using NUnit.Framework;

public class Tests
{
    //pet_years("dog", 5) powinno zwrócić 35. 
    // 
    // 2. pet_years("cat", 9) powinno zwrócić 54. 
    // 
    // 3. pet_years("rabbit", 3) powinno zwrócić 24. 
    // 
    // 4. pet_years("hamster", 4) powinno zwrócić 120. 
    // 
    // 5. pet_years("guinea pig", 5) powinno zwrócić 60. 
    // 
    // 6. pet_years("goldfish", 2) powinno zwrócić 12. 
    // 
    // 7. pet_years("bird", 1) powinno zwrócić 5. 
    [TestCase("dog", 5, 35)]
    [TestCase("cat", 9, 54)]
    [TestCase("rabbit", 3, 24)]
    [TestCase("hamster", 4, 120)]
    [TestCase("guinea pig", 5, 60)]
    [TestCase("goldfish", 2, 12)]
    [TestCase("bird", 1, 5)]
    public void Calc_ReturnsCalculatedAge_WhenPetIsValid(string pet, int humanAge, int expected)
    {
        int? result = PetAgeCalculator.Calc(pet, humanAge);

        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("Lizard")]
    [TestCase("")]
    [TestCase("99")]
    public void Calc_ReturnsNull_WhenPetIsInvalid(string pet)
    {
        int? result = PetAgeCalculator.Calc(pet, 5);

        Assert.That(result, Is.Null);
    }

    [Test]
    public void Calc_ReturnsZero_WhenHumanAgeIsZero()
    {
        int? result = PetAgeCalculator.Calc("Dog", 0);

        Assert.That(result, Is.EqualTo(0));
    }
}