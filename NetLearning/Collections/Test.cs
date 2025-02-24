using System.Collections.ObjectModel;

namespace NetLearning.Collections;

public class Test
{
    private readonly List<string> _names = new List<string>();
    public ReadOnlyCollection<string> Names { get; private set; }
    public Test() => Names = new ReadOnlyCollection<string>(_names);
    public void AddInternally() => _names.Add("test");
}