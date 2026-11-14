public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength <= 0 || sliceLength > numbers.Length)
        {
            throw new ArgumentException("Неправильна довжина рядка");
        }
        int count = numbers.Length - sliceLength + 1;
        string[] result = new string[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = numbers.Substring(i, sliceLength);
        }
        return result;
    }
}
