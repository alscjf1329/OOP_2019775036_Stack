using Node = LinkedList.Node;
using SingleLinkedList = LinkedList.SingleLinkedList;
namespace Stack
{
    class LinkedListStack{
        private SingleLinkedList linkedList;
        private int length;
        private Node top;
        LinkedListStack(){
            linkedList = new SingleLinkedList();
            length=0;
        }
        public void push(object data)
        {
            top=new Node(data);
            linkedList.add(top);
            length++;
        }
        public object pop()
        {
            if(linkedList.isEmpty()){
                Console.Write("Stack is empty!!");
				return null;
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