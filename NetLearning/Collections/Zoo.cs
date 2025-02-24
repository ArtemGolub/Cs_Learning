namespace NetLearning.Collections;

public class Zoo
{
    public readonly AnimalCollection Animals;
    public Zoo()
    {
        Animals = new AnimalCollection(this);
    }
}