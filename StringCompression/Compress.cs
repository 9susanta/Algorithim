using System.Text;

namespace StringCompression
{
    public class Compress
    {
        public static int StringCompress(char[] chars)
        {
            var compressed = new StringBuilder();
            var previousSymbol = chars[0];
            var currentSymbolCount = 1;

            for (int i = 1; i < chars.Length; i++)
            {
                if (previousSymbol == chars[i])
                {
                    currentSymbolCount++;
                }
                else
                {
                    compressed.Append(previousSymbol);
                    if (currentSymbolCount > 1)
                    {
                        compressed.Append(currentSymbolCount);
                    }

                    previousSymbol = chars[i];
                    currentSymbolCount = 1;
                }
            }

            compressed.Append(previousSymbol);
            if (currentSymbolCount > 1)
            {
                compressed.Append(currentSymbolCount);
            }

            var compressedString = compressed.ToString();
            var j = 0;

            foreach (var symbol in compressedString)
            {
                chars[j++] = symbol;
            }

            return compressedString.Length;
        }
    }
}
