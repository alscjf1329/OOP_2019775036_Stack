using Node = LinkedList.Node;

namespace LinkedList
{
    public class SingleLinkedList
    {

        private Node head;
        public SingleLinkedList() {}
        public void add(Node node)
        {
            Node temp = head;
            head = node;
            head.next = temp;
            temp = null;
        }
        public Node remove()
        {
            Node temp = head;
            head = head.next;
            return temp;
        }
        public bool isEmpty()
        {
            if(head == null) return true;
            return false;
        }
    }
}
