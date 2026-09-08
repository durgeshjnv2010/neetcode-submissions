public class Solution {
    public List<string> LetterCombinations(string digits) {
        List<string> result = new();
        if(string.IsNullOrEmpty(digits)){
            return result;
        }
        string[] mapping =
        {
            "",
            "",
            "abc",
            "def",
            "ghi",
            "jkl",
            "mno",
            "pqrs",
            "tuv",
            "wxyz"
        };
        StringBuilder current = new();

        Backtrack(0);

        return result;


        void Backtrack(int index){
            // base case is / All digits processed
            if(index == digits.Length){
                result.Add(current.ToString());
                return;
            }

            // get mappings data for index
            string m = mapping[digits[index]-'0'];

            foreach(char c in m){
                //choose
                current.Append(c);

                //Explore
                Backtrack(index+1);

                //remove
                current.Remove(current.Length-1, 1);

            }

        }
    }
}
