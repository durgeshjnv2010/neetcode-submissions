public class Solution {
    public List<List<string>> Partition(string s) {
        List<List<string>> result = new();
        List<string> current = new();
        Backtrack(0); 
        return result;


        void Backtrack(int start){
            // Base condition: // Whole string consumed
            if(start == s.Length){
                result.Add(new List<string>(current));
            }

            // Try every possible substring starting at 'start'
            for(int end = start; end < s.Length; end++){
                string subs = s.Substring(start, end-start+1);

                // Only choose palindrome parts
                if(!IsPalindrome(subs)){
                    continue;
                }

                //choose
                current.Add(subs);

                // Explore
                Backtrack(end+1);

                //remove
                current.RemoveAt(current.Count-1);
            }

        }
    }

    private bool IsPalindrome(string s){
        int left =0;
        int right = s.Length-1;

        while(left <= right){
            if(s[left] != s[right]){
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
