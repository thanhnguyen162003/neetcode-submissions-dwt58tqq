public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        char[] dataS = s.ToCharArray();
        char[] dataT = t.ToCharArray();
        Array.Sort(dataS);
        Array.Sort(dataT);
        
        return dataS.SequenceEqual(dataT);
    }
}
