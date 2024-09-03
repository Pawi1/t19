namespace lis._28;

public class Zadania
{
    public static void Pre()
    {
        int[,] ints = new int[4,3];
        Console.WriteLine(ints.Rank); //2
        Console.WriteLine(ints.GetLength(0)); //4
        Console.WriteLine(ints.GetLength(1)); //3

        for (int i = 0; i < ints.GetLength(0); i++)
        {
            for (int j = 0; j < ints.GetLength(1); j++)
            {
                Console.Write($"[{i},{j}]= {ints[i,j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n");
        int[,,] cube = new int[4,3,2];
        for (int i = 0; i < cube.GetLength(0); i++)
        {
            Console.WriteLine($"[{i}]");
            for (int j = 0; j < cube.GetLength(1); j++)
            {
                Console.WriteLine($"\t[{i},{j}]");
                for (int k = 0; k < cube.GetLength(2); k++)
                {
                    Console.Write($"\t\t[{i},{j},{k}]= {cube[i,j,k]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}