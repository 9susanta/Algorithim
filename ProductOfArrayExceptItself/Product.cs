namespace ProductOfArrayExceptItself
{
    public class Product
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int i = 0,numProduct=1;
            int[] productArray=new int[nums.Length];
            for(i = 0; i < nums.Length; i++)
            {
                //1,1,2,6
                productArray[i] = numProduct;
                numProduct*=nums[i];
            }
            numProduct = 1;
            for (i = nums.Length-1; i >=0; i--)
            {
                //
                productArray[i] *= numProduct;
                numProduct *= nums[i];
            }
            return productArray;
        }
    }
}
