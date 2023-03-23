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
        }
        public void push(object data)
        {
            top=new Node(data);
        }
        
    }
}