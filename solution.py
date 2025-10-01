class Solution:
    def findLucky(self, arr):
        c = Counter(arr)
        ret = -1
        for x in c:
            if(c[x] == x and x >= ret):
                ret = x
        return(ret)
