class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        
        ret = list()
        for i in range(0,len(nums)-1):  
            sec = target-nums[i]          
            for j in range(i+1, len(nums)):
                if(nums[j] == sec):
                    ret.append(i)
                    ret.append(j)
        return ret
        