using System;

namespace CollectRainWater
{
    class RainWaterTrap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] t1 = { 4, 2, 0, 3, 2, 5 };
            int[] t2 = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            RainWaterTrap rainWaterTrap = new RainWaterTrap();
            Console.WriteLine("Should be 9: " + rainWaterTrap.Trap(t1));
            Console.WriteLine("Should be 6: " + rainWaterTrap.Trap(t2));

        }

        public RainWaterTrap()
        {

        }

        public int Trap(int[] height)
        {
            int[] leftMax = new int[height.Length];
            int[] rightMax = new int[height.Length];
            int[] minDiff = new int[height.Length];
            int[] rainWater = new int[height.Length];
            int rainOutput = 0;

            int max = height[0];
            for (int i = 0; i < height.Length; i++)
            {
                max = Math.Max(height[i], max);
                leftMax[i] = max;
            }

            max = height[height.Length - 1];
            for (int j = height.Length - 1; j >= 0; j--)
            {
                max = Math.Max(height[j], max);
                rightMax[j] = max;
            }

            for (int k = 0; k < height.Length; k++)
            {
                minDiff[k] = Math.Min(leftMax[k], rightMax[k]);
            }

            for (int m = 0; m < minDiff.Length; m++)
            {
                rainWater[m] = minDiff[m] - height[m];
                rainOutput = rainOutput + rainWater[m];
            }

            return rainOutput;
        }
    }
}
