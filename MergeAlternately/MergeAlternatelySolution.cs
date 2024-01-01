using System.Text;

namespace MergeAlternately
{
    public class MergeAlternatelySolution
    {
        public static string MergeAlternately(string word1, string word2)
        {
            int loopLimit = Math.Max(word1.Length, word2.Length);
            StringBuilder result = new StringBuilder(loopLimit);
            for (int i = 0; i < loopLimit; i++)
            {
                if (i < word1.Length)
                {
                    result.Append(word1[i]);
                }
                if (i < word2.Length)
                {
                    result.Append(word2[i]);
                }
            }
            return result.ToString();
        }
    }
}
