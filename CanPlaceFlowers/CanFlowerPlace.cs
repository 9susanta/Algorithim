namespace CanPlaceFlowers
{
    public class CanFlowerPlace
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int emptySpaceNo = 0;

            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 1)
                {

                    continue;
                }
                if (i == 0)
                {
                    if(flowerbed.Length==1&& flowerbed[0] == 0)
                    {
                        emptySpaceNo++;
                    }
                    else if (flowerbed[0] == 0 && flowerbed[1] == 0)
                    {
                        emptySpaceNo++;
                        flowerbed[i] = 1;
                    }
                }
                else if (i == (flowerbed.Length - 1))
                {
                    if (flowerbed[flowerbed.Length - 1] == 0 && flowerbed[flowerbed.Length - 2] == 0)
                    {

                        emptySpaceNo++;
                        flowerbed[i] = 1;
                    }

                }
                else if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                {
                    emptySpaceNo++;
                    flowerbed[i] = 1;
                }

            }
            if (emptySpaceNo >= n) { return true; }
            return false;
        }
    }
}
