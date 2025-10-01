public class Solution {
    public int FindLucky(int[] arr) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for(int i = 0; i < arr.Length; i++){
            if(d.ContainsKey(arr[i])){
                d[arr[i]] = d[arr[i]] + 1;
            }
            else{
                d[arr[i]] = 1;
            }
        }

        int max = -1;
        foreach(int x in d.Keys){
            if(x == d[x] && x >= max){
                max = x;
            }
        }

        return(max);
    }
}
