namespace GreatestNumberCandies
{
    public class GreatestNumberOfCandies
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            //List<bool> list = new List<bool>(candies.Length);
            //int greatest = candies.Max();
            //foreach (int candie in candies)
            //{
            //    if ((candie + extraCandies) >= greatest)
            //    {
            //        list.Add(true);
            //    }
            //    else
            //    {
            //        list.Add(false);
            //    }
            //}
            //return list;
            return candies.Select(x => x + extraCandies >= candies.Max()).ToArray();
        }
    }
}
