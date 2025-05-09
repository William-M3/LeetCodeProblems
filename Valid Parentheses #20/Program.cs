


// public class Solution {
//     public bool IsValid(string s) {

//     if (s.Length % 2 == 1 || !(s[i] == '(' || s[i] == '{' || s[i] == '['))
//     {
//         return false;
//     }

//     Dictionary<char, char> hashMap = new Dictionary<char, char> 
//     {
//         {'(', ')'},
//         {'{', '}'},
//         {'[', ']'}
//     };
//     Stack<char> input = new Stack<char>();


//     for (int i = 0; i < s.Length; i++)
//     {
//         if (s[i] == '(' || s[i] == '{' || s[i] == '[')
//         {
//             input.Push(s[i]);
//         }
//         else
//         {
//             if(input.Count == 0)
//             {
//                 return false;
//             }

//             if(!(hashMap[input.Pop()] == s[i]))
//             {
//                 return false;
//             }

//         }
//     }

//     if (input.Count != 0)
//     {
//         return false;
//     }

//     return true;
//     }
// }


// public class Solution
// {
//     public bool IsValid(string s)
//     {
//         Dictionary<char, char> hashMap = new Dictionary<char, char>
//     {
//         {'(', ')'},
//         {'{', '}'},
//         {'[', ']'}
//     };
//         Stack<char> input = new Stack<char>();


//         for (int i = 0; i < s.Length; i++)
//         {
//             if (s[i] == '(' || s[i] == '{' || s[i] == '[')
//             {
//                 input.Push(s[i]);
//             }
//             else if (input.Count > 0 && s[i] == hashMap[input.Peek()])
//             {
//                 input.Pop();
//             }
//             else
//             {
//                 return false;
//             }
//         }
//         return input.Count == 0;
//     }
// }

Console.WriteLine(IsValid("([])"));


bool IsValid(string s)
{
    Stack<char> input = new Stack<char>();


    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(' || s[i] == '{' || s[i] == '[')
        {
            input.Push(s[i]);
        }
        else if (input.Count > 0)
        {
            if((s[i] - 1) == input.Peek())
            {
                input.Pop();
            }
            else if (s[i] - 2 == input.Peek())
            {
                input.Pop();
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    return input.Count == 0;
}