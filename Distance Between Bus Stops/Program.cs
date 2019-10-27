using System;

namespace Distance_Between_Bus_Stops
{
    class Program
    {
        static void Main(string[] args)
        {

            var distance = new int[] { 1, 2, 3, 4 };


            var r = DistanceBetweenBusStops(distance, 0, 2);
            Console.WriteLine(r);


            Console.ReadLine();
        }

        public static int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            var n = distance.Length;

            if (start > destination)
            {
                var p = start;
                start = destination;
                destination = p;
            }

            var way1 = 0;
            for (int i = start; i < destination; i++)
            {
                way1 += distance[i];
            }

            var way2 = 0;

            for (int i = 0; i < start; i++)
            {
                way2 += distance[i];
            }

            for (int i = destination; i < n; i++)
            {
                way2 += distance[i];
            }


            return way1 > way2 ? way2 : way1;
        }
    }
}
