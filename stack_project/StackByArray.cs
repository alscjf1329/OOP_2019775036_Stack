using System;
namespace vs
{
	public class StackByArray
	{
		private object top;
		private int length;
		private object[] stackArray;

		public StackByArray()
		{
			stackArray = new object[10];
			top = null;
			length = 0;
		}
		public void push(object input)
		{
			if (stackArray.Length < length + 1) Array.Resize(ref stackArray, stackArray.Length * 2);
			stackArray[length] = input;
			top = input;
			length++;
		}

        public object pop()
        {
            return pop(stackArray);
        }

        public object pop(object[] stackArray)
		{
			if (length <= 0)
			{
				Console.Write("Stack is empty!!");
				return null;
			}
			object output = top;
			top = (length - 2 >= 0) ? stackArray[length - 2] : null;
			stackArray[length - 1] = null;
			length--;
			return output;
        }
		public object getTop()
		{
			return top;
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