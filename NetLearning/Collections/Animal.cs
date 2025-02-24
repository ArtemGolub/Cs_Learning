namespace NetLearning.Collections;

public class Animal(string name, int popularity)
{
    private string _name = name;

    public string Name
    {
        get => _name;
        set
        {
            Zoo?.Animals.NotifyNameChange(this, value);
            _name = value;
        }
    }
    public readonly int Popularity = popularity;
    public Zoo? Zoo
    {
        get; 
        internal set;
    }
}