using System.Text;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        StringBuilder result = new StringBuilder(input);
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            char temp = result[left];
            result[left] = result[right];
            result[right] = temp;
            left++;
            right--;
        }
        return result.ToString();
    }
}