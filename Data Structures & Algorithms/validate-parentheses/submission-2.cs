public class Solution {
    public bool IsValid(string s) {
        int left = 0;
        int right = s.Length-1;
        Dictionary<char, char> map = new()
        {
            [')'] = '(',
            [']'] = '[',
            ['}'] = '{'
        };

        Stack<char> stack = new();
        foreach(char c in s){
            if(c == '(' || c== '{' || c=='['){
                stack.Push(c);
            }
            else{
                // No opening bracket to match
                if(stack.Count ==0){
                    return false;
                }
                // Top doesn't match closing bracket
                if(map[c] != stack.Pop()){
                    return false;
                }
            }
        }
        return stack.Count ==0;
    }
}
