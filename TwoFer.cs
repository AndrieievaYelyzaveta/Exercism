public static class TwoFer
{
    public static string Speak()
    {
        return "One for you, one for me.";
    }
    public static string Speak(string name)
    {
        if (name == null || name == "")
        {
            return "One for you, one for me.";
        }
        return "One for " + name + ", one for me.";
    }
}
