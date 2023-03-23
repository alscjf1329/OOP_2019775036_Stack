using StackByArray = vs.StackByArray;


public partial class Program
{
    static void Main(string[] args)
    {
        //배열로 만든 Stack
        StackByArray stack = new StackByArray();
        //push
        stack.push(1);
        stack.push("a");
        stack.push(2);
        stack.push("b");
        stack.push(3);
        stack.push("c");
        //pop
        int num=1;
        while(!stack.isEmpty()) Console.WriteLine("${0}번째 pop: ${1}",num++,stack.pop());
        
    }
}