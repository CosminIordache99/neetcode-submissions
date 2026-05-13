public class Solution {
    public bool IsValid(string s) {

        //s="([{}])"
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> closeToOpen = new Dictionary<char, char> {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (char c in s) {
            if (closeToOpen.ContainsKey(c)) {
                // contain "("? => no
                // contain "[" ? => no
                // contain "{" ? => no
                // contain "}" ? => yes 
                if (stack.Count > 0 && stack.Peek() == closeToOpen[c]) {
                    // stack.Count = 2, stack.Peek = { == closeToOpen[{] => }
                    stack.Pop();
                    //stack = ( [
                } else {
                    return false;
                }
            } else {
                //stack = ( [ {
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
}
