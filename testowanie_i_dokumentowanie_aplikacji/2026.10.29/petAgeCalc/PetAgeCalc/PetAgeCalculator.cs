namespace PetAgeCalc
{
    public enum CalcTable
    {
        Dog = 7,
        Cat = 6,
        Rabbit = 8,
        Hamster = 30,
        GuineaPig = 12,
        GoldFish = 6,
        Bird = 5
    }

    public static class PetAgeCalculator
    {
        public static int? Calc(string pet, int humanAge)
        {
            if (Enum.TryParse<CalcTable>(pet.Replace(" ",""),true, out var petType)
                && Enum.IsDefined(petType))
                return (humanAge * (int) petType);
            return null;
        }
    }
}