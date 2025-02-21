LinkedList<string> tune = new LinkedList<string>();
tune.AddFirst("do");
tune.AddLast("so");

tune.AddAfter(tune.First, "re");
tune.AddAfter(tune.First.Next, "mi");
tune.AddBefore(tune.Last, "fa");

tune.RemoveFirst();
tune.RemoveLast();

LinkedListNode<string> miNode = tune.Find("mi");
tune.Remove(miNode);
tune.AddFirst(miNode);

foreach (string s in tune)
    Console.Write(s);
    
