public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] freq = new int[26];
        foreach(char c in tasks){
            freq[c-'A']++;
        }

        // Highest frequency wale task ko max heap me rakhte h
        PriorityQueue<int, int> maxheap = new();
        foreach(int i in freq){
            if(i > 0){
                maxheap.Enqueue(i, -i);
            }
        }

        // Cycle: if A:2 then A _ _ A if gap(n) is 2
        // so cycle length = n+1

        // take out max freq task
        // execute task, freq-- and temp me add task

        // jab tak ko task bacha h tab tak execute karna h
        int time=0;
        while(maxheap.Count >0){
            int cycle = n+1;

            List<int> temp = new(); // heap se max freq nikalne ke baad 1 task execute hoga to uska bacha hua count rakhenege, fir usko heap me daal denge
            while(maxheap.Count > 0 && cycle >0){
                int f = maxheap.Dequeue(); // max freq wala task ka freq nikla

                // task execute kiya
                f--;

                // agar kuch bacha h to temp me add kiya
                if(f>0){
                    temp.Add(f);
                }

                time++;
                cycle--;

                // 

            }
            // cycle ke baad agar task bacha h to add back to heap
            foreach(int f in temp){
                if(f>0){
                    maxheap.Enqueue(f, -f);
                }
            }

            // abhi bhi agar task bacha h to cycle me wo task idle hoga
            if(maxheap.Count >0){
                time +=cycle;
            }

        }
        return time;
    }
}
