public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string text = input.ToLower();
        for (int i = 0; i < alphabet.Length; i++)
        {
            if (!text.Contains(alphabet[i]))
            {
                return false;
            }
        }
        return true;
    }
}
