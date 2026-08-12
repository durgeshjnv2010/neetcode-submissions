public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] frequency = new int[26];
        foreach(char c in tasks){
            frequency[c - 'A']++;
        }
        int maxFreq = 0;
        for (int i =0;i<frequency.Length;i++){
            maxFreq = Math.Max(maxFreq, frequency[i]);
        }

        int taskWithMaxFreq = 0;
        for (int i =0;i<frequency.Length;i++){
            if(frequency[i] == maxFreq){
                taskWithMaxFreq++;
            }
        }

        int maxTime = (maxFreq - 1)*(n+1) + taskWithMaxFreq;

        return Math.Max(tasks.Length, maxTime);
    }
}
