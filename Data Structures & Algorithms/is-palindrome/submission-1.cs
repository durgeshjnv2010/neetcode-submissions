public class Solution {
    public bool IsPalindrome(string s) {
        char[] arr = s.ToCharArray();
        int left=0;
        int right=s.Length-1;
        while(left<right){
            while(left<right && !IsLetterOrDigit(arr[left])){
                left++; 
            }
            while(left<right &&  !IsLetterOrDigit(arr[right])){
                right--;
            }
            if(!(char.ToLower(arr[left]) == char.ToLower(arr[right]))){
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    private bool IsLetterOrDigit(char c){
        if((c >= 'A' && c<='Z') || (c >= 'a' && c<='z') || (c >= '0' && c<='9')){
            return true;
        }
        return false;
    }
}
