Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);

int[] data = stack.ToArray();
Console.WriteLine(stack.Count);
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());