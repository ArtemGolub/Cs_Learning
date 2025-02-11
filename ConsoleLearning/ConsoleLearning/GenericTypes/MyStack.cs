namespace ConsoleLearning.GenericTypes;

public class MyStack<T>
{
    private int position;
    private T[] data = new T[100];
    public void Push(T obj) => data[position++] = obj;
    public T Pop() => data[--position];
}