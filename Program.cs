internal class Program
{
    private static void Main(string[] args)
    {
        int[] num = new int[] { 4, 1, 3, 5, 2, 9, 7, 72, 6, 5 };

        for (int j = 0; j < num.Length; j++)
        {
            Console.Write(num[j] + "\t");
        }
        int sort = num.Length - 1;

        while (sort > 0)
        {
            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] > num[i + 1])
                {

                    int c = num[i];
                    num[i] = num[i + 1];
                    num[i + 1] = c;
                }


            }
            sort--;
        }

        Console.WriteLine();
        for (int j = 0; j < num.Length; j++)
        {
            Console.Write(num[j] + "\t");
        }
    }
}