//Assignment 6.1.3: Move Zeroes
//Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
//Note that you must do this in-place without making a copy of the array.
int[] num1 = [0, 1, 0, 3, 12];

int[] result = MoveZeroes(num1);

foreach (int number in result)
{
    Console.Write(number + " ");
}

int[] MoveZeroes(int[] nums)
{
    int insertIndex = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != 0)
        {
            int temp = nums[insertIndex];
            nums[insertIndex] = nums[i];
            nums[i] = temp;

            insertIndex++;
        }
    }

    return nums;
}
