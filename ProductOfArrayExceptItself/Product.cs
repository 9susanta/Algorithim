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
                //1,1,1,3
                productArray[i] = numProduct;
                Console.WriteLine(productArray[i]);
                numProduct*=nums[i];
            }
            Console.WriteLine("---------------------");
            numProduct = 1;
            for (i = nums.Length-1; i >=0; i--)
            {
                //3
                productArray[i] *= numProduct;
                Console.WriteLine(productArray[i]);
                numProduct *= nums[i];
            }
            return productArray;
        }
    }
}
