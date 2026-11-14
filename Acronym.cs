public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string[] words = phrase.Replace('-', ' ').Replace('_', ' ').Split(' ');
        string result = "";
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                result = result + char.ToUpper(words[i][0]);
            }
        }
        return result;
    }
}
