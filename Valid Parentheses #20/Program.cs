public class Solution {
    public bool IsValid(string s) {
        
        
    if (s.Length % 2 == 1)
    {
        return false;
    }
    
    Dictionary<char, char> hashMap = new Dictionary<char, char> 
    {
        {'(', ')'},
        {'{', '}'},
        {'[', ']'}
    };
    Stack<char> input = new Stack<char>();
    
    
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(' || s[i] == '{' || s[i] == '[')
        {
            input.Push(s[i]);
        }
        else
        {
            if(input.Count == 0)
            {
                return false;
            }

            if(!(hashMap[input.Pop()] == s[i]))
            {
                return false;
            }

        }
    }

    if (input.Count != 0)
    {
        return false;
    }

    return true;
    }
}