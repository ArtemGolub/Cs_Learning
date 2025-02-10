using ConsoleLearning.ObjectTypes;

Stack stack = new Stack();
stack.Push("Sausage");
string s = (string)stack.Pop();
Console.WriteLine(s);