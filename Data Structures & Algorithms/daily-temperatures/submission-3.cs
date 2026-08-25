public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int len = temperatures.Length;
        int[] result = new int[temperatures.Length];

        Stack<int> stack = new();
        for(int i=0; i< len;i++){
            while(stack.Count >0 && temperatures[i] > temperatures[stack.Peek()]){
                int prevday = stack.Pop();
                result[prevday]=i-prevday;
            }
            stack.Push(i);
        }

        return result;
    }
}
