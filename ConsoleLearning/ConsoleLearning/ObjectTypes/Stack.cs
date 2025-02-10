namespace ConsoleLearning.ObjectTypes;

public class Stack
{
    private int position;
    private object[] data = new object[10];
    public void Push(object obj) => data[position++] = obj;
    public object Pop() => data[--position];
    
}