using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < identifier.Length; i++)
        {
            if (char.IsWhiteSpace(identifier[i]))
                sb.Append('_');
            else if (char.IsControl(identifier[i]))
                sb.Append("CTRL");
            else if (identifier[i] == '-')
            {
                i++;
                sb.Append(char.ToUpper(identifier[i]));
            }
            else if (!char.IsLetter(identifier[i]))
                continue;
            else if (identifier[i] >= 945 && identifier[i] <= 969)
                continue;
            else
                sb.Append(identifier[i]);
        }
        return sb.ToString();
    }
}
