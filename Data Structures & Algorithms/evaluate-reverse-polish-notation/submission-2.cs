public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new();
        foreach(string s in tokens){
            if(int.TryParse(s, out int n)){
                stack.Push(n);
            }
            else{
                int b= stack.Pop();
                int a= stack.Pop();
                int result = 0;
                if(s == "+"){
                    result=a+b;
                }
                else if(s=="-"){
                    result=a-b;
                }
                else if(s=="*"){
                    result = a*b;
                }
                else if(s=="/"){
                    if(b==0){
                        throw new ArgumentException();
                    }
                    else{
                        result=a/b;
                    }
                }
                stack.Push(result);
            }
            
        }
        return stack.Pop();
    }
}
