public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[],double> maxheap = new();
        double distance = 0;
        //first calculate distance
        for(int i=0; i<points.Length; i++){
            // Eucledian Formula: (sqrt((x1 - x2)^2 + (y1 - y2)^2))
            // Example coordinates
            double x1 = 0, y1 = 0;  //origin
            double x2 = points[i][0], y2 = points[i][1];  // ith point in points

            // Calculate differences
            double deltaX = x1 - x2;
            double deltaY = y1 - y2;

            // Distance formula using direct multiplication for squaring
            distance = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
            maxheap.Enqueue([points[i][0], points[i][1]], -distance);

            if(maxheap.Count > k){
                maxheap.Dequeue();
            }
        }
        // 1. Initialize the outer jagged array with the size 'k'
        int[][] resp = new int[k][]; 
        int index = 0;

        while (k > 0) {
            // 2. Dequeue the coordinates/data from your heap
            int[] point = maxheap.Dequeue(); 
            
            // 3. Assign it to the current index moving forward from 0
            resp[index] = point; 
            
            index++;
            k--;
        }
        return resp;
        // add to max heap and if count >k then dequeue
    }
}
