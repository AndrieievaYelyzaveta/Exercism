public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        string text = number.ToString();
        int power = text.Length;
        int sum = 0;
        for (int i = 0; i < text.Length; i++)
        {
            int digit = text[i] - '0';
            sum = sum + (int)Math.Pow(digit, power);
        }
        return sum == number;
    }
}
