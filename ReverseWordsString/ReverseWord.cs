using System.Text;

namespace ReverseWordsString
{
    public class ReverseWord
    {
        public static string ReverseWords(string s)
        {
            var stringSplit = s.Trim().Split(" ");
            var reverseString = new StringBuilder();
            int j = 0;
            for (int indx = stringSplit.Length-1; indx >= 0; indx--)
            {
                if (string.IsNullOrEmpty(stringSplit[indx]))
                {
                    continue;
                }
                reverseString.Append(stringSplit[indx]);
                if(indx!=0)
                    reverseString.Append(" ");
                j++;
            }
            return reverseString.ToString();
            //return String.Join(" ", s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
        }
    }
}
