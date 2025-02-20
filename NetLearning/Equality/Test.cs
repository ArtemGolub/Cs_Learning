namespace NetLearning.Equality;

public class Test<T> where T: IEquatable<T>
{
    public bool IsEquals(T a, T b) =>
         a.Equals(b); // упаковка с обобщенным типом T не происходит
}