namespace LabAlgorithms;
public static class Generators
{
    public static int[] GenerateRandom(int size, int minValue, int maxValue)
    {
        var rnd = new Random();
        var result = new int[size];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = rnd.Next(minValue, maxValue);
        }

        return result;
    }

    public static int[] GenerateSorted(int size, int minValue, int maxValue)
    {
        var result = GenerateRandom(size, minValue, maxValue);

        Array.Sort(result);

        return result;
    }

    public static int[] GenerateReversed(int size, int minValue, int maxValue)
    {
        var result = GenerateRandom(size, minValue, maxValue);

        Array.Reverse(result);

        return result;
    }
}