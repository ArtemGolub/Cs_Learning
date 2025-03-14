namespace ASP_Core_Learning.GC;

public class Disposable: IDisposable
{
    public static Disposable Create(Action onDispose)
        => new Disposable(onDispose);
    
    private Action _onDispose;
    Disposable(Action onDispose) => _onDispose = onDispose;

    public void Dispose()
    {
        _onDispose?.Invoke(); // выполнить действие освобожения, если не null
        _onDispose = null; // обеспечить чтобы его нельзя было выполнить еще раз
    }
}