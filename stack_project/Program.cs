using ArrayStack = Stack.ArrayStack;
using LinkedListStack = Stack.LinkedListStack;

public partial class Program
{
    static void Main(string[] args)
    {
        //Array로 만든 Stack
        Console.WriteLine("ArrayStack----------");
        ArrayStack arrayStack = new ArrayStack();
        //push
        arrayStack.push(1);
        arrayStack.push("a");
        arrayStack.push(2);
        arrayStack.push("b");
        arrayStack.push(3);
        arrayStack.push("c");
        //pop
        int num=1;
        while(!arrayStack.isEmpty()) Console.WriteLine("${0}번째 pop: ${1}",num++,arrayStack.pop());
        
        //LinkedList로 만든 Stack
        Console.WriteLine("LinkedListStack----------");
        LinkedListStack linkedListStack = new LinkedListStack();
        //push
        linkedListStack.push(1);
        linkedListStack.push("a");
        linkedListStack.push(2);
        linkedListStack.push("b");
        linkedListStack.push(3);
        linkedListStack.push("c");
        //pop
        num=1;
        while(!linkedListStack.isEmpty()) Console.WriteLine("${0}번째 pop: ${1}",num++,linkedListStack.pop());
    }
}