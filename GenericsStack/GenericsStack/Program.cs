namespace GenericsStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Top element: " + stack.Peek());

            int popItem = stack.Pop();
            Console.WriteLine("Pop element: " + popItem);

            Console.WriteLine("Current count: " + stack.Count);

            stack.Clear();
            Console.WriteLine("After clear, count: " + stack.Count);
        }
    }
}