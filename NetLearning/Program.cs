using System.Collections.ObjectModel;

Zoo zoo = new Zoo();
zoo.Animals.Add(new Animal("Kangaroo", 10));
zoo.Animals.Add(new Animal("Lion", 20));
foreach (Animal animal in zoo.Animals)
    Console.WriteLine(animal.Name + " " + animal.Popularity + " " + animal.Zoo);

public class Animal(string name, int popularity)
{
    public string Name { get; set; } = name;
    public int Popularity { get; set; } = popularity;
    public Zoo? Zoo { get; internal set; }
}

public class Zoo
{
    public readonly AnimalCollection Animals;
    public Zoo()
    {
        Animals = new AnimalCollection(this);
    }
}

public class AnimalCollection(Zoo zoo) : Collection<Animal>
{
    private Zoo _zoo = zoo;

    protected override void InsertItem(int index, Animal item)
    {
        base.InsertItem(index, item);
        item.Zoo = _zoo;
    }

    protected override void SetItem(int index, Animal item)
    {
        base.SetItem(index, item);
        item.Zoo = _zoo;
    }

    protected override void RemoveItem(int index)
    {
        this[index].Zoo = null;
        base.RemoveItem(index);
    }

    protected override void ClearItems()
    {
        foreach (Animal animal in this)
            animal.Zoo = null;
        base.ClearItems();
    }
}