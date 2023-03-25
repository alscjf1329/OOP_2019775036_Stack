namespace LinkedList
{
    public class SingleLinkedList<T>
    {
        private Node<T>? head;
        public SingleLinkedList() {}
        public void add(Node<T> node)
        {
            Node<T>? temp = head;
            head = node;
            head.next = temp;
            temp = null;
        }
        public Node<T>? remove()
        {
            if(head == null) return null;
            Node<T>? temp = head;
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
