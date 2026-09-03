public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> d = new();  // max heap me int, -int
        foreach(int i in stones){
            d.Enqueue(i, -i);
        }
        while(d.Count > 1){
            int a = d.Dequeue();
            int b = d.Dequeue();

            if(a != b){
                int res = Math.Abs(a-b);
                d.Enqueue(res, -res);
            }
        }
        return d.Count > 0 ? d.Dequeue() : 0;

    }
}
