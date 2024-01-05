using System.Text;

namespace ReverseVowel
{
    public class ReverseString
    {
        public static string ReverseVowels(string s)
        {
            var vowelArray = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            var reverseVowelS = new StringBuilder(s);

            var foundVowels = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (vowelArray.Contains(s[i]))
                {
                    foundVowels.Push(s[i]);
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (vowelArray.Contains(s[i]))
                {
                    reverseVowelS[i] = foundVowels.Pop();
                }
            }
            return reverseVowelS.ToString();
        }
    }
}
