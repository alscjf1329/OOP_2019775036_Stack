namespace Stack
{
	public class ArrayStack<T> : StackStruct<T>
	{
		private T? top;
		private int length;
		private T[] stackArray;

		public ArrayStack()
		{
			stackArray = new T[10];
			length = 0;
		}
		public void push(T input)
		{
			if (stackArray.Length < length + 1) Array.Resize(ref stackArray, stackArray.Length * 2);
			stackArray[length] = input;
			top = input;
			length++;
		}

        public T? pop()
		{
			if (length <= 0)
			{
				Console.WriteLine("Stack is empty!!");
				return default(T);
			}
			T? output = top;
			top = (length - 2 >= 0) ? stackArray[length - 2] : default(T);
			stackArray[length - 1] = default(T);
			length--;
			return output;
        }
		public bool isEmpty()
		{
			if(length<=0){
				return true;
			}
			return false;
		}
		
	}
}