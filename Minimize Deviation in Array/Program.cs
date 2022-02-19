// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
var arr = new int[] { 1, 2, 3, 4 };

Console.WriteLine(MinimumDeviation(arr));
Console.WriteLine(MinimumDeviation(new int[] { 4, 1, 5, 20, 3 }));

//quesion:将数组的最大数和最小数偏差最小。如果是偶数，除以2，如果是奇数，乘以2

//思路 因为奇数只能*2一次，所以把所有的奇数都*2，并找出其中最小的数，并将所有的数放入优先队列
//  因为dequeue的时候是先最低优先级，所以需要添加负号，因为我们需要从大到小


//cheat version
static int MinimumDeviation(int[] nums)
{
    PriorityQueue<int, int> pq = new();
    int n = nums.Length;
    var min = int.MaxValue;
    var res = int.MaxValue;

    for (int i = 0; i < n; i++)
    {
        if (nums[i] % 2 == 1)
        {
            nums[i] *= 2;
        }
        pq.Enqueue(nums[i], -nums[i]);
        min = Math.Min(min, nums[i]);
    }

    while (true)
    {
        int a = pq.Dequeue();
        res = Math.Min((int)a - min, res);
        if (a % 2 == 1)
        {
            break;
        }
        min = Math.Min(min, a / 2);
        pq.Enqueue(a / 2, -a / 2);
    }

    return res;
}

