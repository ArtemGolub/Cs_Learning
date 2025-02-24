namespace NetLearning.EqualityComparers;

public class LastFirstEqComparer : EqualityComparer<Customer>
{
    public override bool Equals(Customer x, Customer y)
        => x.LastName == y.LastName && x.FirstName == y.FirstName;

    public override int GetHashCode(Customer obj)
        => (obj.LastName + ";" + obj.FirstName).GetHashCode();
}