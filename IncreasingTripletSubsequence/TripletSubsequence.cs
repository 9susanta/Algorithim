namespace IncreasingTripletSubsequence
{
    public class TripletSubsequence
    {
        public static bool IncreasingTriplet(int[] nums)
        {
            if(nums.Length<3)
            {
                return false;
            }
            int smallestNo = nums[0];
            int smallNo = int.MaxValue;
            bool isTriplate = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= smallestNo)
                    smallestNo = nums[i];
                else if (nums[i] <= smallNo)
                    smallNo = nums[i];
                else
                {
                    isTriplate = true;
                    break;
                }
            }
            return isTriplate;
        }
    }
}
