public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int sum = 0;
        for (int number = 1; number < max; number++)
        {
            foreach (int multiple in multiples)
            {
                if (multiple > 0 && number % multiple == 0)
                {
                    sum += number;
                    break;
                }
            }
        }
        return sum;
    }
}
