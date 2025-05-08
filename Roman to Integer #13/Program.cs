
Console.WriteLine(RomanToInt("IV"));

int RomanToInt(string s)
{
    Dictionary<char, int> valueMap = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},

    };
    int result = 0;

    for (int i = 0; i < s.Length; i++)
    {

        if (i + 1 < s.Length)
        {
            if (valueMap[s[i]] < valueMap[s[i + 1]])
            {
                result += valueMap[s[i + 1]] - valueMap[s[i]];
                i++;
                continue;
            }
        }
        result += valueMap[s[i]];
    }
    return result;

}