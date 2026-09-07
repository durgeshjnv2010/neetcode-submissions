public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        List<string> result = new();

        StringBuilder current = new();
        // max open and close will be n
        Backtrack(0,0);

        return result;


        void Backtrack(int open, int close){
            // total length n*2 hoga open close mila ke
            if(current.Length == n*2){
                result.Add(current.ToString());
            }

            // Choice 1: add '('
            if(open < n){
                current.Append('(');
                Backtrack(open+1, close);
                current.Remove(current.Length-1,1);
            }

            // Choice 2: add ')'

            if(close<open){
                current.Append(')');
                Backtrack(open, close+1);
                current.Remove(current.Length-1, 1);
            }
        }
    }
}
