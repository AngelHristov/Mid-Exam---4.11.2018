namespace _01._Party_Profit
{
    using System;

    public class PartyProfit
    {
        public static void Main()
        {
            int companions = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    companions -= 2;
                }
                if (i % 15 == 0)
                {
                    companions += 5;
                }
                sum += 50;
                sum -= companions * 2;
                if (i % 3 == 0)
                {
                    sum -= companions * 3;
                }
                if (i % 5 == 0)
                {
                    sum += companions * 20;
                    if (i % 3 == 0)
                    {
                        sum -= companions * 2;
                    }
                }
            }

            int sumPerComp = (int)sum / companions;
            Console.WriteLine($"{companions} companions received {sumPerComp} coins each.");
        }
    }
}
