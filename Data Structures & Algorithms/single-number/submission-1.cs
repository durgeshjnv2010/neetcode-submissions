public class Solution {
    public int SingleNumber(int[] nums) {
        int result = 0;

        //xor operator ^=
        // The XOR operator has three key properties that make this work seamlessly: AlgoMonster +1\(A \oplus 0 = A\) (Any number XORed with zero stays the same) Stack Overflow +1\(A \oplus A = 0\) (Any number XORed with itself cancels out to zero) YouTube +1Commutative & Associative (\(A \oplus B \oplus A = A \oplus A \oplus B = 0 \oplus B = B\)) Dry Run Example with [4, 1, 2, 1, 2]: result = 00 ^ 4 → 44 ^ 1 → 55 ^ 2 → 77 ^ 1 → 6 (Notice the 1s have now canceled out)6 ^ 2 → 4 (Notice the 2s have now canceled out)

        foreach(int n in nums){
            result ^= n;
        }

        return result;
    }
}
