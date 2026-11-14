public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string text = word.ToLower();
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ' && text[i] != '-')
            {
                for (int j = i + 1; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }
}
