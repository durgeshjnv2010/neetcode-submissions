public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int maxArea = 0;
        Stack<int> stack = new();

        for(int i=0;i<=heights.Length;i++){
            int ch = (i==heights.Length) ? 0:heights[i];
            while(stack.Count > 0 && ch < heights[stack.Peek()])
            {
                int h = heights[stack.Pop()];
                int width = (stack.Count ==0) ?  i : (i-stack.Peek()-1);
                maxArea=Math.Max(maxArea, h*width);
            }



            stack.Push(i);
        }
        return maxArea;
    }
}
