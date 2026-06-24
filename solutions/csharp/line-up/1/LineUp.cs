public static class LineUp
{
    public static string Format(string name, int number)
    {
        string numResult = CheckNumber(number.ToString());
        return $"{name}, you are the {number}{numResult} customer we serve today. Thank you!";
    }

    private static string CheckNumber(string num)
    {
        char lastChar = num[^1];

        if (num.Length >= 2)
        {
            string lastDigits = num.Substring(num.Length - 2);
            if (lastDigits == "11" || lastDigits == "12" || lastDigits == "13")
                return "th";
        }
        
        return lastChar switch
        {
            '1' => "st",
            '2' => "nd",
            '3' => "rd",
            _ => "th"
        };
    }
}
