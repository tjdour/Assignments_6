//Assignment 6.2.2
//Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
//The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
//You must write an algorithm that runs in O(n) time and without using the division operation.


int[] num1 = [1, 2, 3, 4];
int[] num2 = [-1, 1, 0, -3, 3];

int[] result1 = ProductExceptSelf(num1);
int[] result2 = ProductExceptSelf(num2);

PrintArray(result1);
PrintArray(result2);

int[] ProductExceptSelf(int[] nums)
{
    int[] prefix = new int[nums.Length];
    int[] suffix = new int[nums.Length];
    int[] answer = new int[nums.Length];

    prefix[0] = 1;

    // Build prefix products
    for (int i = 1; i < nums.Length; i++)
    {
        prefix[i] = prefix[i - 1] * nums[i - 1];
    }

    suffix[nums.Length - 1] = 1;

    // Build suffix products
    for (int i = nums.Length - 2; i >= 0; i--)
    {
        suffix[i] = suffix[i + 1] * nums[i + 1];
    }

    // Combine prefix and suffix
    for (int i = 0; i < nums.Length; i++)
    {
        answer[i] = prefix[i] * suffix[i];
    }

    return answer;
}

void PrintArray(int[] nums)
{
    foreach (int num in nums)
    {
        Console.Write(num + " ");
    }

    Console.WriteLine();
}