internal class Program
{
    private static void Main(string[] args)
    {
        int P = Convert.ToInt32(Console.ReadLine());
        int[] p_num = PNum(P);
        foreach (int i in p_num)
        {
            foreach (int j in p_num)
            {
                if ((i+j) == P) Console.WriteLine($"({i};{j})");
            }
        }
    }

    static int[] PNum(int x)
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(5);
        for (int i = 2; i <= x; i++)
        {
            if (isSimple(i)) list.Add(i);
        }

        return list.ToArray();

        static bool isSimple(int N)
        {
            bool tf = false;
            for (int i = 2; i < (int)(N / 2); i++)
            {
                if (N % i == 0)
                {
                    tf = false;
                    break;
                }
                else
                {
                    tf = true;
                }
            }
            return tf;
        }
    }
}