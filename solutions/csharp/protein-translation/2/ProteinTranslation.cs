using System.Text;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        List<string> proteins = new List<string>();

        for (int i = 0; i + 3 <= strand.Length; i += 3)
        {
            string codon = strand.Substring(i, 3);
            string protein = ProteinMapper(codon);

            if (protein == "STOP")
            {
                break;
            }
            
            proteins.Add(protein);
        }
        return proteins.ToArray();
    }

    private static string ProteinMapper(string codon)
    {
        return codon switch
        {
            "AUG" => "Methionine",
            "UUU" or "UUC" => "Phenylalanine",
            "UUA" or "UUG" => "Leucine",
            "UCU" or "UCC" or "UCA" or "UCG" => "Serine",
            "UAU" or "UAC" => "Tyrosine",
            "UGU" or "UGC" => "Cysteine",
            "UGG" => "Tryptophan",
            "UAA" or "UAG" or "UGA" => "STOP",
            _ => throw new ArgumentException($"Unknown codon: {codon}")
        };
    }
}