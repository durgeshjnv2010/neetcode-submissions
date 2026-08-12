class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        dictC = dict()
        for i in nums:
            if i in dictC:
                dictC[i] = dictC[i]+1
            else:
                dictC[i] = 1
        for k, v in dictC.items():
            if v > 1:
                return True
            
        return False