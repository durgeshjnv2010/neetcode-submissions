public class KthLargest {
    private readonly int k ;
    private readonly PriorityQueue<int, int> minheap;

    public KthLargest(int k, int[] nums) {
        this.k =k;
        minheap = new PriorityQueue<int, int>();
        foreach(int n in nums){
            Add(n);
        }
    }
    
    public int Add(int val) {
        minheap.Enqueue(val, val);

        if(minheap.Count > k){
            minheap.Dequeue();
        }

        return minheap.Peek();
    }

    // Min Heap
}
