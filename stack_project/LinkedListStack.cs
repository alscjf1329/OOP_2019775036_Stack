using LinkedList;

namespace Stack
{
    public class LinkedListStack<T> : StackStruct<T>
    {
        private SingleLinkedList<T> linkedList;
        private int length;
        private Node<T>? top;
        public LinkedListStack(){
            linkedList = new SingleLinkedList<T>();
            length=0;
        }
        public void push(T data)
        {
            top=new Node<T>(data);
            linkedList.add(top);
            length++;
        }
        public T? pop()
        {
            if(linkedList.isEmpty()){
                Console.WriteLine("Stack is empty!!");
				return default(T);
            } 
            length--;
            return linkedList.remove().data;
        }
        public bool isEmpty()
        {
            return linkedList.isEmpty();
        }
    }
}