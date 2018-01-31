using System;

namespace Container_With_Most_Water
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(MaxArea(new int[] { 1, 2, 3, 4, 5 }));

            Console.ReadKey();
        }

        public static int MaxArea(int[] height)
        {

            var maxArea = 0;

            var left = 0;

            var right = height.Length - 1;

            for (int i = 1; i < height.Length; i++)
            {
                maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));

                if (height[left] > height[right])
                {
                    right -= 1;
                }
                else
                {
                    left += 1;
                }
            }

            return maxArea;
        }

        public int MaxAreas(int[] height)
        {
            int length = height.Length;
            int maxLeft = 0;
            int maxRight = 0;
            int maxArea = 0;
            int currentLeft = 0;
            int currentRight = length - 1;

            while (currentLeft < currentRight)
            {
                int currentLeftHeight = height[currentLeft];
                int currentRightHeight = height[currentRight];

                int newArea = Area(currentLeft, currentRight, currentLeftHeight, currentRightHeight);
                maxArea = maxArea > newArea ? maxArea : newArea;


                maxLeft = maxLeft > currentLeftHeight ? maxLeft : currentLeftHeight;
                maxRight = maxRight > currentRightHeight ? maxRight : currentRightHeight;

                if (maxLeft < maxRight) { currentLeft++; } else { currentRight--; }

            }

            return maxArea;
        }

        public int Area(int leftX, int rightX, int leftHeight, int rightHeight)
        {
            return Math.Min(leftHeight, rightHeight) * (rightX - leftX);
        }

    }
}
