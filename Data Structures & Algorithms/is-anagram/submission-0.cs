public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }


        //r a c e c a r
        //0 1 2 3 4 5 6

        //countS[s[i]] => s[i] = s[0] = r => countS[r] = countS.GetValue(s[r], 0) = 0 + 1 =>1
        //countS[s[i]] => s[i] = s[6] = r => countS[r] = countS.GetValue(s[r], 0) = 1 + 1 =>2

        Dictionary<char, int> countS = new Dictionary<char, int>();
        Dictionary<char, int> countT = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            countS[s[i]] = countS.GetValueOrDefault(s[i], 0) + 1;
            countT[t[i]] = countT.GetValueOrDefault(t[i], 0) + 1;
        }
        return countS.Count == countT.Count && !countS.Except(countT).Any();
    }
}
