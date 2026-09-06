public class Solution
{
    public int[][] KClosest(int[][] points, int k)
    {
        PriorityQueue<int[], long> maxHeap = new();

        for (int i = 0; i < points.Length; i++)
        {
            int x = points[i][0];
            int y = points[i][1];

            long distance = (long)x * x + (long)y * y;

            // Negative priority => farthest comes first
            maxHeap.Enqueue(points[i], -distance);

            if (maxHeap.Count > k)
            {
                maxHeap.Dequeue();
            }
        }

        int[][] result = new int[k][];

        for (int i = 0; i < k; i++)
        {
            result[i] = maxHeap.Dequeue();
        }

        return result;
    }
}