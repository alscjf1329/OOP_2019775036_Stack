namespace Stack
{
    public interface StackStruct<T>
    {
        public void push(T data);
        public T? pop();
        public bool isEmpty();
    }   
}
