using Node=LinkedList.Node;
public class SingleLinkedList
{
    
    private Node head;
    public SingleLinkedList(){}
    public void add(Node node)
    {
        Node temp = head;
        head = node;
        head.next = temp;
        temp = null;
    }
    public object remove()
    {
        Node temp = head;
        head = head.next;
        object data = temp.data;
        temp = null;
        return data;
    }
    
    
}