public class KthLargest {
    private int k;
    private PriorityQueue<int, int> q;

    public KthLargest(int k, int[] nums) {
        this.k=k;
        q = new();
        foreach(int i in nums){
            Add(i);
        }
    }
    
    public int Add(int val) {
        q.Enqueue(val,val);
        if(q.Count > k){
            q.Dequeue();
        }
        return q.Peek();
    }
}
