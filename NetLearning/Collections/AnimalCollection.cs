using System.Collections.ObjectModel;

namespace NetLearning.Collections;

public class AnimalCollection(Zoo zoo) : KeyedCollection<string, Animal>
{
    private Zoo _zoo = zoo;
    internal void NotifyNameChange(Animal animal, string newName) => this.ChangeItemKey(animal, newName);
    
    protected override string GetKeyForItem(Animal item) => item.Name;
    
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