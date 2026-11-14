public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        int eggs = 0;
        while (encodedCount > 0)
        {
            if (encodedCount % 2 == 1)
            {
                eggs++;
            }
            encodedCount = encodedCount / 2;
        }
        return eggs;
    }
}
