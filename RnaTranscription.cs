public static class RnaTranscription
{
    public static string ToRna(string strand)
    {
        string rna = "";
        for (int i = 0; i < strand.Length; i++)
        {
            if (strand[i] == 'G')
            {
                rna = rna + 'C';
            }
            else if (strand[i] == 'C')
            {
                rna = rna + 'G';
            }
            else if (strand[i] == 'T')
            {
                rna = rna + 'A';
            }
            else if (strand[i] == 'A')
            {
                rna = rna + 'U';
            }
        }
        return rna;
    }
}
