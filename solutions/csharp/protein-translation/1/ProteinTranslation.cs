using System.Text;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        StringBuilder stringBuilder = new StringBuilder();
        List<string> proteins = new List<string>();
        int i = 0;

        while (i < strand.Length)
        {
            int j = i;
            int k = i + 3;
            
            while (j < k)
            {
                stringBuilder.Append(strand[i++]);
                j++;
            }
            if (ProteinMapper(stringBuilder.ToString()) == "STOP")
            {
                break;
            }
            proteins.Add(ProteinMapper(stringBuilder.ToString()));
            stringBuilder.Clear();
        }
        return proteins.ToArray();
    }

    private static string ProteinMapper(string currentProtein)
    {
        switch (currentProtein)
        {
            case "AUG":
                return "Methionine";
            case "UUU" or "UUC":
                return "Phenylalanine";
            case "UUA" or "UUG":
                return "Leucine";
            case "UCU" or "UCC" or "UCA" or "UCG":
                return "Serine";
            case "UAU" or "UAC":
                return "Tyrosine";
            case "UGU" or "UGC":
                return "Cysteine";
            case "UGG":
                return "Tryptophan";
            case "UAA" or "UAG" or "UGA":
                return "STOP";
        }

        return "";
    }
}