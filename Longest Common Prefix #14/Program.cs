
string LongestCommonPrefix(string[] strs)
{
    string prefix = "";
    Array.Sort(strs);
    for (int i = 0; i < strs[0].Length; i++)
    {
        for (int j = 1; j < strs.Length; j++)
        {
            if (strs[0][i] != strs[j][i])
                return prefix;
        }
        prefix += strs[0][i];
    }
    return prefix;
}