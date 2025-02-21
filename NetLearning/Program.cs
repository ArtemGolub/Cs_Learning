Queue<int> q = new Queue<int>();
q.Enqueue(10);
q.Enqueue(20);

int[] data = q.ToArray();
Console.WriteLine(q.Count);
Console.WriteLine(q.Peek());
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());