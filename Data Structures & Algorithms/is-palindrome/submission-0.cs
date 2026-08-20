public class Solution {
    public bool IsPalindrome(string s) {
        int i=0;
        int j = s.Length -1;
        char[] arr= s.ToCharArray();
        while(i<j){
            while(i<j && !IsLetterOrDigit(arr[i])){
                i++;
            }
            while(i<j && !IsLetterOrDigit(arr[j])){
                j--;
            }
            if(char.ToLower(arr[i]) != char.ToLower(arr[j])){
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
    private bool IsLetterOrDigit(char c){
        if(((c >= 'A' && c<='Z') || (c >='a' && c<='z')) || (c >= '0' && c <= '9')){
            return true;
        }
        return false;
    }
}
