using System;
public static class Kata
{
    
    public static void Main(string[] args)
    {
        int[] dice = new int[] { 4, 4, 4, 3, 3 };
       Console.WriteLine(Score(dice));
    }
    //calculate the number of numbers
    public static int Score(int[] dice)
    {
        int[] nums =new int[] {0, 0, 0, 0, 0, 0, 0};
        for (int i = 0; i < dice.Length; i++)
        {
            nums[dice[i]]++;
        }

        int go = 5;
        int result = 0;
      
        for (int i = 1; i < nums.Length; i++)
        {
            switch (i)
            {
                case 1:

                    if (nums[i] >= 3)
                    {
                        result += ((nums[i] / 3)*1000)+(nums[i]%3)*100;
                    }
                    else
                    {
                        result+= nums[i] * 100;
                    }
                        break;
                case 2:
                    if (nums[i] >= 3)
                    {
                        result += (nums[i] / 3) * 200;
                    }
                    break;
                case 3:
                    if (nums[i] >= 3)
                    {
                        result += (nums[i] / 3) * 300;
                    }
                    break;
                case 4:
                    if (nums[i] >= 3)
                    {
                       
                        result += (nums[i] / 3) * 400;
                    }
                    break;
                case 5:
                    if (nums[i] >= 3)
                    {
                        result += ((nums[i] / 3) * 500) + (nums[i]%3)*50;
                    }
                    else
                    {
                        result += nums[i] * 50;
                    }
                    break;
                case 6:
                    if (nums[i] >= 3)
                    {
                        result += (nums[i] / 3) * 600;
                    }
                    break;
            }
        }

        return result;
        Console.WriteLine("hey");
    }}