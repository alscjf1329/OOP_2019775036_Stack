using Stack;

public partial class Program
{
    static void Main(string[] args)
    {
        //Array로 만든 Stack
        Console.WriteLine("ArrayStack----------");
        ArrayStack<String> arrayStack = new ArrayStack<String>();
        //push
        arrayStack.push("a");
        arrayStack.push("b");
        arrayStack.push("c");
        arrayStack.push("d");
        arrayStack.push("e");
        arrayStack.push("f");
        //pop
        int num=1;
        while(!arrayStack.isEmpty()) Console.WriteLine("${0}번째 pop: ${1}",num++,arrayStack.pop());
        
        //LinkedList로 만든 Stack
        Console.WriteLine("LinkedListStack----------");
        LinkedListStack<int> linkedListStack = new LinkedListStack<int>();
        //push
        linkedListStack.push(1);
        linkedListStack.push(2);
        linkedListStack.push(3);
        linkedListStack.push(4);
        linkedListStack.push(5);
        linkedListStack.push(6);
        //pop
        num=1;
        while(!linkedListStack.isEmpty()) Console.WriteLine("${0}번째 pop: ${1}",num++,linkedListStack.pop());
    }
}